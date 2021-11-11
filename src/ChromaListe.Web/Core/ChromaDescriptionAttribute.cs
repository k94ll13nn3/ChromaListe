namespace ChromaListe.Web.Core;

[AttributeUsage(AttributeTargets.All)]
public sealed class ChromaDescriptionAttribute : Attribute
{
    public ChromaDescriptionAttribute(string description)
    {
        Description = description;
    }

    public ChromaDescriptionAttribute(string description, string shortDescription)
    {
        Description = description;
        ShortDescription = shortDescription;
    }

    public string Description { get; }

    public string? ShortDescription { get; }
}
