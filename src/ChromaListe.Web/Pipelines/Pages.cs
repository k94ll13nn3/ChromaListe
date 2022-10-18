using ChromaListe.Web.Core;
using Statiq.Razor;
using Statiq.Yaml;

namespace ChromaListe.Web.Pipelines;

public class Pages : Pipeline
{
    public Pages()
    {
        Dependencies.AddRange(new[]
        {
                PipelineNames.Posts,
            });

        InputModules = new ModuleList
            {
                new ReadFiles("**/*.cshtml")
            };

        ProcessModules = new ModuleList
            {
                new ExtractFrontMatter(new ParseYaml()),
                new RenderRazor().WithLayout((NormalizedPath)"/_Page.cshtml"),
                new SetDestination(".html")
            };

        OutputModules = new ModuleList
            {
                new WriteFiles()
            };
    }
}
