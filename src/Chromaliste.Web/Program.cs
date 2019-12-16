using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Json;
using Statiq.Markdown;
using Statiq.Minification;
using Statiq.Razor;
using Statiq.Sass;
using Statiq.Yaml;

namespace Chromaliste.Web
{
    public static class Program
    {
        private static async Task<int> Main(string[] args)
        {
            int i = 0;
            return await Bootstrapper
                .CreateDefault(args)
                .ConfigureSettings(c =>
                {
                    c["SiteTitle"] = "Shiny Living Dex";
                    c[Keys.Host] = "k94ll13nn3.github.io";
                    c[Keys.LinkRoot] = "/ChromaListe";
                })
                .BuildPipeline(
                    "Sass",
                    builder => builder
                        .WithInputReadFiles("assets/css/master.scss")
                        .WithProcessModules(new CompileSass().WithCompressedOutputStyle())
                        .WithOutputWriteFiles()
                )
                .BuildPipeline(
                    "PokemonJson",
                    builder => builder
                        .WithInputReadFiles("pokemons.json")
                        .WithProcessModules(new ParseJson())
                )
                .BuildPipeline(
                    "Posts",
                    builder => builder
                        .WithDependencies("PokemonJson")
                        .WithInputReadFiles("posts/**/*.md")
                        .WithProcessModules(
                            new ExtractFrontMatter(new ParseYaml()),
                            new RenderMarkdown(),
                            new SetMetadata("Title", Config.FromDocument((doc, ctx) => (ctx.Outputs.FromPipeline("PokemonJson").First().First().Value as System.Collections.Generic.List<dynamic>)?.Single(p => doc.GetString("Number") == p.number.ToString()).name.ToString())),
                            new SetMetadata("Date", Config.FromDocument(doc => doc.Source.FileName.ToString().Substring(0, 10))),
                            new SetMetadata("Image", Config.FromDocument((doc, ctx) => ctx.GetLink($"/assets/img/pokemon/{doc.GetString("Number")}.png"))),
                            new SetMetadata("PostFile", Config.FromDocument(doc => $"posts/{doc.Source.FileNameWithoutExtension}.html")),
                            new SetMetadata("PostFileSlug", Config.FromDocument(doc => Slugify(doc.GetString("PostFile"))))
                        )
                        .WithOutputWriteFiles(Config.FromDocument(doc => (FilePath)doc.GetString("PostFile")))
                )
                .BuildPipeline(
                    "RenderPosts",
                    builder => builder
                        .WithDependencies("Posts")
                        .WithProcessModules(
                            new ReplaceDocuments("Posts"),
                            new RenderRazor().WithLayout((FilePath)"/_Post.cshtml")
                        )
                        .WithOutputWriteFiles(Config.FromDocument(doc => (FilePath)doc.GetString("PostFile")))
                )
                .BuildPipeline(
                    "Pages",
                    builder => builder
                        .WithDependencies("Posts", "PokemonJson")
                        .WithInputReadFiles("**/{!home,*}.cshtml")
                        .WithProcessModules(
                            new ExtractFrontMatter(new ParseYaml()),
                            new RenderRazor().WithLayout((FilePath)"/_Page.cshtml")
                        )
                        .WithOutputWriteFiles(".html")
                )
                .BuildPipeline(
                    "Categories",
                    builder => builder
                        .WithDependencies("Posts", "PokemonJson")
                        .WithProcessModules(
                            new ReplaceDocuments("Posts"),
                            new GroupDocuments("Category"),
                            new FilterDocuments(Config.FromDocument(doc => !string.IsNullOrEmpty(doc.GetString(Keys.GroupKey)))),
                            new ForEachDocument(
                                new SetMetadata("Posts", Config.FromDocument(doc => doc.GetChildren())),
                                new SetMetadata("Title", Config.FromDocument(doc => doc.GetString(Keys.GroupKey))),
                                new SetMetadata("Subtitle", Config.FromDocument(doc => $"Pokémon attrapés avec la méthode <strong>‘{doc.GetString(Keys.GroupKey)}’</strong>")),
                                new SetMetadata("RelativeFilePath", Config.FromDocument(doc => $"categories/{Slugify(doc.GetString(Keys.GroupKey))}/index.html"))
                            ),
                            new RenderRazor().WithLayout((FilePath)"/_Category.cshtml")
                        )
                        .WithOutputWriteFiles(Config.FromDocument(doc => (FilePath)doc.GetString("RelativeFilePath")))
                )
                .BuildPipeline(
                    "RazorScripts",
                    builder => builder
                        .WithDependencies("Posts", "PokemonJson")
                        .WithInputReadFiles("assets/js/_scripts.cshtml")
                        .WithProcessModules(
                            new RenderRazor().IgnorePrefix(null),
                            new MinifyJs()
                        )
                        .WithOutputWriteFiles(Config.FromDocument(_ => (FilePath)"assets/js/scripts.js"))
                )
                .BuildPipeline(
                    "Index",
                    builder => builder
                        .WithDependencies("Posts", "PokemonJson")
                        .WithInputReadFiles("home.cshtml")
                        .WithProcessModules(
                            new ReplaceDocuments("Posts"),
                            new OrderDocuments("PostFile").Descending(),
                            new PaginateDocuments(9),
                            new RenderRazor().WithLayout((FilePath)"/_Page.cshtml")
                        )
                        .WithOutputWriteFiles(Config.FromDocument(_ => (FilePath)$"page{i++}/index.html"))
                )
                .BuildPipeline(
                    "Resources",
                    builder => builder
                        .WithProcessModules(new CopyFiles("**/*{!.cshtml,!.markdown,!.md,!.less,!.scss,!.json,}"))
                )
                .RunAsync();
        }

        private static string Slugify(string value)
        {
            value = value.ToLowerInvariant();
            var bytes = CodePagesEncodingProvider.Instance.GetEncoding("Cyrillic").GetBytes(value);
            value = Encoding.ASCII.GetString(bytes);
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);
            value = Regex.Replace(value, @"[^\w\s\p{Pd}]", string.Empty, RegexOptions.Compiled);
            value = value.Trim('-', '_');
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }
    }
}