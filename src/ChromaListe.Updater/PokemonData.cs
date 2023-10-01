using System.Text.Json.Serialization;

namespace ChromaListe.Updater;

public class PokemonData
{
    [JsonPropertyName("num")]
    public double Number { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("baseSpecies")]
    public string? BaseName { get; set; }

    [JsonPropertyName("forme")]
    public string Form { get; set; } = string.Empty;

    [JsonPropertyName("types")]
    public IList<string> Types { get; } = new List<string>();

    [JsonPropertyName("tags")]
    public IList<string> Tags { get; } = new List<string>();

    public string PrimaryType => Types[0];

    public string? SecondaryType => Types.Count > 1 ? Types[1] : null;

    public string? TagList => Tags.Count > 0 ? string.Join('|', Tags) : null;
}
