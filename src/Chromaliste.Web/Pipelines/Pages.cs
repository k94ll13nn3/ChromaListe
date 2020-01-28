using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;
using Statiq.Yaml;

namespace ChromaListe.Web.Pipelines
{
    public class Pages : Pipeline
    {
        public Pages()
        {
            Dependencies.AddRange(new[]
            {
                nameof(Posts),
            });

            InputModules = new ModuleList
            {
                new ReadFiles(Config.FromDocument(_ => "**/*.cshtml"))
            };

            ProcessModules = new ModuleList
            {
                new ExtractFrontMatter(new ParseYaml()),
                new RenderRazor().WithLayout((FilePath)"/_Page.cshtml"),
                new SetDestination(".html")
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
