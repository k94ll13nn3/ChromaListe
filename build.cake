//////////////////////////////////////////////////////////////////////
// TOOLS
//////////////////////////////////////////////////////////////////////

#tool Wyam&version=2.2.5
#tool KuduSync.NET&version=1.5.2

//////////////////////////////////////////////////////////////////////
// ADDINS
//////////////////////////////////////////////////////////////////////

#addin Cake.Wyam&version=2.2.5
#addin Cake.Git&version=0.21.0
#addin Cake.Kudu&version=0.10.1

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var outputPath = MakeAbsolute(Directory("./output"));
var rootPublishFolder = MakeAbsolute(Directory("./publish"));

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean-Documentation")
    .Does(() =>
{
    EnsureDirectoryExists(outputPath);
    EnsureDirectoryExists(rootPublishFolder);
});

Task("Build-Documentation")
    .IsDependentOn("Clean-Documentation")
    .WithCriteria(() => !string.IsNullOrWhiteSpace(EnvironmentVariable("GITHUB_TOKEN")), "Environment variable \"GITHUB_TOKEN\" not set.")
    .WithCriteria(() => AppVeyor.IsRunningOnAppVeyor)
    .WithCriteria(() => !AppVeyor.Environment.PullRequest.IsPullRequest)
    .Does(() =>
{
    Wyam();

    var accessToken = EnvironmentVariable("GITHUB_TOKEN");
    var deployRemote = @"https://github.com/k94ll13nn3/ChromaListe.git";
    var deployBranch = "gh-pages";
    var sourceCommit = GitLogTip("./");

    Information("Publishing documentation...");
    var publishFolder = rootPublishFolder.Combine(DateTime.Now.ToString("yyyyMMdd_HHmmss"));

    Information("Getting publish branch...");
    GitClone(deployRemote, publishFolder, new GitCloneSettings{ BranchName = deployBranch });

    Information("Sync output files...");
        Kudu.Sync(outputPath, publishFolder, new KuduSyncSettings { 
        ArgumentCustomization = args=>args.Append("--ignore").AppendQuoted(".git;CNAME")
    });

    Information("Stage all changes...");
    GitAddAll(publishFolder);

    Information("Commit all changes...");
    GitCommit(
        publishFolder,
        sourceCommit.Committer.Name,
        sourceCommit.Committer.Email,
        string.Format("AppVeyor Publish: {0}\r\n{1}", sourceCommit.Sha, sourceCommit.Message)
    );

    Information("Pushing all changes...");
    GitPush(publishFolder, accessToken, "x-oauth-basic", deployBranch);
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Build-Documentation");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);