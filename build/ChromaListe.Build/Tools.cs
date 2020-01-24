using System;
using System.Globalization;
using System.IO;
using static SimpleExec.Command;

namespace Strinken.Build
{
    public static class Tools
    {
        public static void DeploySite(string tokenName, string owner, string project)
        {
            if (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("APPVEYOR_PULL_REQUEST_NUMBER")))
            {
                Console.WriteLine("Not running on pull requests.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(tokenName)))
            {
                Console.WriteLine($"Environment variable \"{tokenName}\" not set.");
                return;
            }

            bool isRunningOnAppVeyor = !string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("APPVEYOR"));
            if (!isRunningOnAppVeyor)
            {
                Console.WriteLine("Not running on AppVeyor.");
                return;
            }

            string lastCommitMessage = Read("git", "log -1 --pretty=format:%B");
            string rootPublishFolder = Path.GetFullPath($"./publish");

            if (Directory.Exists(rootPublishFolder))
            {
                Directory.Delete(rootPublishFolder, true);
            }

            string publishFolder = Path.Combine(rootPublishFolder, DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture));
            string deployRemote = $"https://github.com/{owner}/{project}.git";
            const string deployBranch = "gh-pages";
            string lastCommiterName = Read("git", "log -1 --pretty=format:%an");
            string lastCommiterEmail = Read("git", "log -1 --pretty=format:%ae");
            string lastCommitHash = Read("git", "log -1 --pretty=format:%h");

            Run("git", $"clone {deployRemote} -b {deployBranch} {publishFolder}");
            Run("git", "rm -rf .", publishFolder);
            Run("xcopy", @"..\..\output . /E", publishFolder);
            Run("git", "add .", publishFolder);
            Run("git", "config --global credential.helper store", publishFolder);
            Run("git", $"config --global user.email {lastCommiterEmail}", publishFolder);
            Run("git", $"config --global user.name {lastCommiterName}", publishFolder);
            Run("powershell", $@"Add-Content ""$env:USERPROFILE\.git-credentials"" ""https://$($env:{tokenName}):x-oauth-basic@github.com`n""", publishFolder);
            Run("git", $"commit -a -m \"AppVeyor Publish: {lastCommitHash}\r\n{lastCommitMessage}\"", publishFolder);
            Run("git", "push", publishFolder);
        }
    }
}
