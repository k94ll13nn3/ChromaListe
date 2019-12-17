using Chromaliste.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Razor;

namespace Chromaliste.Web.Pipelines
{
    public class Categories : Pipeline
    {
        public Categories()
        {
            Dependencies.AddRange(new[]
            {
                nameof(PokemonJson),
                nameof(Posts),
            });

            ProcessModules = new ModuleList
            {
                new ReplaceDocuments(nameof(Posts)),
                new GroupDocuments(CustomKeys.Category),
                new FilterDocuments(Config.FromDocument(doc => !string.IsNullOrEmpty(doc.GetString(Keys.GroupKey)))),
                new ForEachDocument(
                    new SetMetadata(CustomKeys.Posts, Config.FromDocument(doc => doc.GetChildren())),
                    new SetMetadata(CustomKeys.Title, Config.FromDocument(doc => doc.GetString(Keys.GroupKey))),
                    new SetMetadata(CustomKeys.Subtitle, Config.FromDocument(doc => $"Pokémon attrapés avec la méthode <strong>‘{doc.GetString(Keys.GroupKey)}’</strong>")),
                    new SetMetadata(CustomKeys.RelativeFilePath, Config.FromDocument(doc => $"categories/{doc.GetString(Keys.GroupKey).Slugify()}/index.html"))
                ),
                new RenderRazor().WithLayout((FilePath)"/_Category.cshtml"),
                new SetDestination(Config.FromDocument(doc => (FilePath)doc.GetString(CustomKeys.RelativeFilePath)))
            };

            OutputModules = new ModuleList
            {
                new WriteFiles()
            };
        }
    }
}