﻿using Chromaliste.Web.Core;
using ChromaListe.Web.Core;
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
            InputModules = new ModuleList
            {
                new ReadFiles("posts/**/*.md")
            };

            ProcessModules = new ModuleList
            {
                new ExtractFrontMatter(new ParseYaml()),
                new RenderMarkdown(),
                new SetMetadata(CustomKeys.Title, Config.FromDocument(doc => Pokemon.Get(doc.GetString("Number")).Name)),
                new SetMetadata(CustomKeys.Date, Config.FromDocument(doc => doc.Source.FileName.ToString().Substring(0, 10))),
                new SetMetadata(CustomKeys.Image, Config.FromDocument((doc, ctx) => ctx.GetLink($"/assets/img/pokemon/{doc.GetString(CustomKeys.Number)}.{(doc.ContainsKey("switch") ? "jpg" : "png")}"))),
                new SetMetadata(CustomKeys.WritePath, Config.FromDocument(doc => $"posts/{doc.Source.FileNameWithoutExtension}.html")),
            };
        }
    }
}