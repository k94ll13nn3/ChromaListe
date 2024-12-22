namespace ChromaListe.Web.Core;

public sealed record PostData
{
    public PostData(IDocument? document)
    {
        Number = document.GetString(CustomKeys.Number);
        Name = document.GetString(CustomKeys.Title);
        CatchDate = document.GetDateTime(CustomKeys.Date);
        Category = document.Get<Category>(CustomKeys.Category);
        CaughtAs = document.GetString(CustomKeys.Caught);
        Location = document.GetString(CustomKeys.Location);
        Level = document.GetString(CustomKeys.Level);
        Version = document.Get<GameVersion>(CustomKeys.Version);
        Ball = document.Get<Ball>(CustomKeys.Ball);
        WritePath = document.GetString(CustomKeys.WritePath);
        Image = document.GetString(CustomKeys.Image);
        ImageSuffix = document.GetString(CustomKeys.ImageSuffix);
    }

    public string Number { get; set; }

    public string Name { get; set; }

    public DateTime CatchDate { get; set; }

    public Category Category { get; set; }

    public string? CaughtAs { get; set; }

    public string Location { get; set; }

    public string Level { get; set; }

    public GameVersion Version { get; set; }

    public Ball Ball { get; set; }

    public string WritePath { get; set; }

    public string Image { get; set; }

    public string? ImageSuffix { get; set; }
}
