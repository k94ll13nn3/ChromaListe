using ChromaListe.Web.Core;
using Statiq.Razor;
using Statiq.Yaml;

namespace ChromaListe.Web.Pipelines;

public class Pages : Pipeline
{
    public Pages()
    {
        Dependencies.AddRange(PipelineNames.Posts);

        InputModules =
        [
            new ReadFiles("**/*.cshtml")
        ];

        ProcessModules =
        [
            new ExtractFrontMatter(new ParseYaml()),
            new RenderRazor().WithLayout((NormalizedPath)"/_Page.cshtml"),
            new SetDestination(".html")
        ];

        OutputModules =
        [
            new WriteFiles()
        ];
    }
}
