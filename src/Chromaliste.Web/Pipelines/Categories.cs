using ChromaListe.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;

namespace ChromaListe.Web.Pipelines
{
    public class Categories : Pipeline
    {
        public Categories()
        {
            Dependencies.AddRange(new[]
            {
                PipelineNames.Posts,
            });

            ProcessModules = new ModuleList
            {
                new ReplaceDocuments(PipelineNames.Posts),
                new GroupDocuments(CustomKeys.Category),
                new FilterDocuments(Config.FromDocument(doc => !string.IsNullOrEmpty(doc.GetString(Keys.GroupKey)))),
                new ForEachDocument(
                    new SetMetadata(CustomKeys.CategoryPosts, Config.FromDocument(doc => doc.GetChildren())),
                    new SetMetadata(CustomKeys.Title, Config.FromDocument(doc => doc.Get<Category>(Keys.GroupKey).GetDescription())),
                    new SetMetadata(CustomKeys.Subtitle, Config.FromDocument(doc => $"Pokémon attrapés avec la méthode <strong>‘{doc.Get<Category>(Keys.GroupKey).GetDescription()}’</strong>")),
                    new SetMetadata(CustomKeys.WritePath, Config.FromDocument(doc => $"categories/{doc.GetString(Keys.GroupKey).Slugify()}/index.html"))
                ),
                new RenderRazor().WithLayout((NormalizedPath)"/_Category.cshtml"),
                new SetDestination(Config.FromDocument(doc => (NormalizedPath)doc.GetString(CustomKeys.WritePath)))
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}
