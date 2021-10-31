using System.Diagnostics.CodeAnalysis;
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
    [SuppressMessage("Usage", "CA2227", Justification = "Used only for serialization.")]
    public IList<string> Types { get; set; } = new List<string>();

    [JsonPropertyName("tags")]
    [SuppressMessage("Usage", "CA2227", Justification = "Used only for serialization.")]
    public IList<string> Tags { get; set; } = new List<string>();

    public string PrimaryType => Types[0];

    public string? SecondaryType => Types.Count > 1 ? Types[1] : null;

    public string? PrimaryTag => Tags.Count > 0 ? Tags[0] : null;
}
