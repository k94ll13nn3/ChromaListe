using Statiq.Common;
using Statiq.Core;
using Statiq.Sass;

namespace ChromaListe.Web.Pipelines
{
    public class Sass : Pipeline
    {
        public Sass()
        {
            InputModules = new ModuleList
            {
                new ReadFiles("assets/css/master.scss")
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