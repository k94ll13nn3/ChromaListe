using ChromaListe.Web.Core;
using Statiq.Yaml;

namespace ChromaListe.Web.Pipelines;

internal sealed class Posts : Pipeline, INamedPipeline
{
    public Posts()
    {
        InputModules =
        [
            new ReadFiles("posts/**/*.md")
        ];

        ProcessModules =
        [
            new ExtractFrontMatter(new ParseYaml()),
            new SetMetadata(CustomKeys.Title, Config.FromDocument(doc => Pokemon.Get(doc.GetString(CustomKeys.Number)).Name)),
            new SetMetadata(CustomKeys.Date, Config.FromDocument(doc => doc.Source.FileName.ToString().Substring(0, 10))),
            new SetMetadata(CustomKeys.Image, Config.FromDocument((doc, ctx) => ctx.GetLink($"/assets/img/pokemon/{doc.GetString(CustomKeys.Number)}{doc.GetString(CustomKeys.ImageSuffix)}.jpg"))),
            new SetMetadata(CustomKeys.Icon, Config.FromDocument((doc, ctx) => ctx.GetLink($"/assets/img/icons/{doc.GetString(CustomKeys.Number).PadLeft(doc.GetString(CustomKeys.Number).EndsWith('a') || doc.GetString(CustomKeys.Number).EndsWith('g') ? 5 : 4, '0')}.png"))),
            new SetMetadata(CustomKeys.WritePath, Config.FromDocument(doc => $"posts/{doc.Source.FileNameWithoutExtension}.html")),
        ];
    }

    public string PipelineName => PipelineNames.Posts;
}
