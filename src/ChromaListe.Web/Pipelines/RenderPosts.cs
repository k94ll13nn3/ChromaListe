using ChromaListe.Web.Core;
using ChromaListe.Web.Modules;
using Statiq.Razor;

namespace ChromaListe.Web.Pipelines;

internal sealed class RenderPosts : Pipeline
{
    public RenderPosts()
    {
        Dependencies.AddRange(PipelineNames.Posts);

        ProcessModules =
        [
            new CheckDuplicates(),
            new ReplaceDocuments(PipelineNames.Posts),
            new RenderRazor().WithLayout((NormalizedPath)"/_Post.cshtml"),
            new SetDestination(Config.FromDocument(doc => (NormalizedPath)doc.GetString(CustomKeys.WritePath))),
        ];

        OutputModules =
        [
            new WriteFiles()
        ];
    }
}
