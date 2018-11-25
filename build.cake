// Inspired from https://github.com/cake-contrib/Cake.Recipe/blob/develop/Cake.Recipe/Content/wyam.cake

//////////////////////////////////////////////////////////////////////
// TOOLS
//////////////////////////////////////////////////////////////////////

#tool nuget:?package=Wyam&version=2.0.0
#tool nuget:?package=KuduSync.NET&version=1.5.2

//////////////////////////////////////////////////////////////////////
// ADDINS
//////////////////////////////////////////////////////////////////////

#addin nuget:?package=Cake.Wyam&version=2.0.0
#addin nuget:?package=Cake.Git&version=0.19.0
#addin nuget:?package=Cake.Kudu&version=0.8.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var isRunningOnAppVeyor = AppVeyor.IsRunningOnAppVeyor;
var isPullRequest = AppVeyor.Environment.PullRequest.IsPullRequest;
var accessToken = EnvironmentVariable("access_token");
var deployRemote = @"https://github.com/k94ll13nn3/ChromaListe.git";
var deployBranch = "gh-pages";
var sourceCommit = GitLogTip("./");
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
    .Does(() =>
{
    Wyam();

    if (isRunningOnAppVeyor && !isPullRequest)
    {
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
    }
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