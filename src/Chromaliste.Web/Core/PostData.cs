using System;
using Statiq.Common;

namespace ChromaListe.Web.Core
{
    public record PostData
    {
        public PostData(IDocument document)
        {
            Number = document.GetString(CustomKeys.Number);
            Name = document.GetString(CustomKeys.Title);
            CatchDate = document.GetDateTime(CustomKeys.Date);
            Category = document.Get<Category>(CustomKeys.Category);
            CaughtAs = document.GetString(CustomKeys.Caught);
            Location = document.GetString(CustomKeys.Location);
            Level = document.GetInt(CustomKeys.Level);
            Version = document.Get<GameVersion>(CustomKeys.Version);
            Ball = document.Get<Ball>(CustomKeys.Ball);
            WritePath = document.GetString(CustomKeys.WritePath);
            Image = document.GetString(CustomKeys.Image);
            Icon = document.GetString(CustomKeys.Icon);
        }

        public string Number { get; set; }

        public string Name { get; set; }

        public DateTime CatchDate { get; set; }

        public Category Category { get; set; }

        public string? CaughtAs { get; set; }

        public string Location { get; set; }

        public int Level { get; set; }

        public GameVersion Version { get; set; }

        public Ball Ball { get; set; }

        public string WritePath { get; set; }

        public string Image { get; set; }

        public string Icon { get; set; }
    }
}
