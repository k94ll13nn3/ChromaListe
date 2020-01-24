using static Bullseye.Targets;
using static SimpleExec.Command;

namespace Strinken.Build
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Target(
                "build",
                 () => Run("dotnet", @"run --project .\src\ChromaListe.Web\"));

            Target(
                "deploy",
                DependsOn("build"),
                () => Tools.DeploySite("GITHUB_TOKEN", "k94ll13nn3", "ChromaListe"));

            Target("default", DependsOn("deploy"));

            Target(
                "preview",
                 () => Run("dotnet", @"run --project .\src\ChromaListe.Web\ -- preview --virtual-dir=/ChromaListe"));

            RunTargetsAndExit(args);
        }
    }
}
