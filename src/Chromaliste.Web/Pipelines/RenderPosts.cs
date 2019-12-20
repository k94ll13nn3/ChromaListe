using Chromaliste.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;

namespace Chromaliste.Web.Pipelines
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
                new RenderRazor().WithLayout((FilePath)"/_Post.cshtml"),
                new SetDestination(Config.FromDocument(doc => (FilePath)doc.GetString(CustomKeys.WritePath))),
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}