﻿using static Bullseye.Targets;
using static SimpleExec.Command;

namespace Strinken.Build
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Target(
                "build",
                 () => Run("dotnet", @"run --project .\src\Chromaliste.Web\"));

            Target(
                "deploy",
                DependsOn("build"),
                () => Tools.DeploySite("GITHUB_TOKEN", "k94ll13nn3", "Strinken"));

            Target("default", DependsOn("deploy"));

            RunTargetsAndExit(args);
        }
    }
}