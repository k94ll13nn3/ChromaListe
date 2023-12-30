using System.Text.Json.Serialization;

namespace ChromaListe.Updater;

public class PokemonData
{
    [JsonPropertyName("num")]
    public double Number { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("baseSpecies")]
    public string? BaseName { get; set; }

    [JsonPropertyName("prevo")]
    public string? PreEvolution { get; set; }

    [JsonPropertyName("forme")]
    public string? Form { get; set; }

    [JsonPropertyName("types")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>")]
    public IList<string> Types { get; set; } = [];

    [JsonPropertyName("tags")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>")]
    public IList<string> Tags { get; set; } = [];

    public string PrimaryType => Types[0];

    public string? SecondaryType => Types.Count > 1 ? Types[1] : null;

    public string? TagList => Tags.Count > 0 ? string.Join('|', Tags) : null;

    public double SpeciesNumber { get; set; }

    public string TranslatedName { get; set; } = null!;
}
