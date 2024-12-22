using ChromaListe.Web.Core;
using Statiq.Minification;
using Statiq.Razor;

namespace ChromaListe.Web.Pipelines;

public sealed class RazorScripts : Pipeline
{
    public RazorScripts()
    {
        Dependencies.AddRange(PipelineNames.Posts);

        InputModules =
        [
            new ReadFiles("assets/js/_scripts.cshtml")
        ];

        ProcessModules =
        [
            new RenderRazor().IgnorePrefix(null),
            new MinifyJs(),
            new SetDestination(Config.FromDocument(_ => (NormalizedPath)"assets/js/scripts.js"))
        ];

        OutputModules =
        [
            new WriteFiles()
        ];
    }
}
