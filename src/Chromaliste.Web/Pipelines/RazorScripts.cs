using ChromaListe.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Minification;
using Statiq.Razor;

namespace ChromaListe.Web.Pipelines
{
    public class RazorScripts : Pipeline
    {
        public RazorScripts()
        {
            Dependencies.AddRange(new[]
            {
                PipelineNames.Posts,
            });

            InputModules = new ModuleList
            {
                new ReadFiles("assets/js/_scripts.cshtml")
            };

            ProcessModules = new ModuleList
            {
                new RenderRazor().IgnorePrefix(null),
                new MinifyJs(),
                new SetDestination(Config.FromDocument(_ => (NormalizedPath)"assets/js/scripts.js"))
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
