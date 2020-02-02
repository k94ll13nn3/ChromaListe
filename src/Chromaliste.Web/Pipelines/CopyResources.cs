using Statiq.Common;
using Statiq.Core;

namespace ChromaListe.Web.Pipelines
{
    public class CopyResources : Pipeline
    {
        public CopyResources()
        {
            Isolated = true;

            ProcessModules = new ModuleList
            {
                new CopyFiles("**/*{!.cshtml,!.md,!.scss,}")
            };
        }
    }
}
