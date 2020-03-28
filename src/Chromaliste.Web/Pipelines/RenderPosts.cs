using ChromaListe.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;

namespace ChromaListe.Web.Pipelines
{
    public class RenderPosts : Pipeline
    {
        public RenderPosts()
        {
            Dependencies.AddRange(new[]
            {
                nameof(Posts),
            });

            ProcessModules = new ModuleList
            {
                new ReplaceDocuments(nameof(Posts)),
                new RenderRazor().WithLayout((NormalizedPath)"/_Post.cshtml"),
                new SetDestination(Config.FromDocument(doc => (NormalizedPath)doc.GetString(CustomKeys.WritePath))),
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
