using System.Linq;
using Chromaliste.Web.Core;
using Statiq.Common;
using Statiq.Core;
using Statiq.Markdown;
using Statiq.Yaml;

namespace Chromaliste.Web.Pipelines
{
    public class Posts : Pipeline
    {
        public Posts()
        {
            Dependencies.AddRange(new[]
            {
                nameof(PokemonJson),
            });

            InputModules = new ModuleList
            {
                new ReadFiles("posts/**/*.md")
            };

            ProcessModules = new ModuleList
            {
                new ExtractFrontMatter(new ParseYaml()),
                new RenderMarkdown(),
                new SetMetadata(CustomKeys.Title, Config.FromDocument((doc, ctx) => (ctx.Outputs[nameof(PokemonJson)][0].First().Value as System.Collections.Generic.List<dynamic>)?.Single(p => doc.GetString("Number") == p.number.ToString()).name.ToString())),
                new SetMetadata(CustomKeys.Date, Config.FromDocument(doc => doc.Source.FileName.ToString().Substring(0, 10))),
                new SetMetadata(CustomKeys.Image, Config.FromDocument((doc, ctx) => ctx.GetLink($"/assets/img/pokemon/{doc.GetString(CustomKeys.Number)}.png"))),
                new SetMetadata(CustomKeys.WritePath, Config.FromDocument(doc => $"posts/{doc.Source.FileNameWithoutExtension}.html")),
            };
        }
    }
}