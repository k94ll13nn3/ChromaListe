using Statiq.Common;
using Statiq.Core;
using Statiq.Sass;

namespace ChromaListe.Web.Pipelines
{
    public class GenerateSass : Pipeline
    {
        public GenerateSass()
        {
            InputModules = new ModuleList
            {
                new ReadFiles(Config.FromDocument(_ => "assets/css/master.scss"))
            };

            ProcessModules = new ModuleList
            {
                new CompileSass().WithCompressedOutputStyle()
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
