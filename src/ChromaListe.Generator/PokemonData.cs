namespace ChromaListe.Generator;

public class PokemonData(double number, string name, string form, string primaryTpe, string? secondaryTpe, string[] tags, double speciesNumber, Dictionary<string, int> games)
{
    public double Number { get; set; } = number;

    public string Name { get; set; } = name;

    public string Form { get; set; } = form;

    public string PrimaryTpe { get; set; } = primaryTpe;

    public string? SecondaryTpe { get; set; } = secondaryTpe;

    public string[] Tags { get; set; } = tags;

    public double SpeciesNumber { get; set; } = speciesNumber;

    public Dictionary<string, int> Games { get; set; } = games;

    public string DisplayName => Form switch
    {
        "Alola" => $"{Name} (Alola)",
        "Galar" => $"{Name} (Galar)",
        "Hisui" => $"{Name} (Hisui)",
        "Paldea" => $"{Name} (Paldea)",
        _ => Name,
    };

    public string PrimaryGroup => Form switch
    {
        "Alola" => "Groups.Alola",
        "Galar" => "Groups.Galar",
        "Hisui" => "Groups.Hisui",
        "Paldea" => "Groups.Paldea",
        _ => $"Groups.{GetGeneration((int)Number)}",
    };

    public string DisplayNumber => Form switch
    {
        "Alola" => $"{Number}a",
        "Galar" => $"{Number}g",
        "Hisui" => $"{Number}h",
        "Paldea" => $"{Number}p",
        _ => $"{Number}",
    };

    private static string GetGeneration(int number)
    {
        return number switch
        {
            _ when number <= 151 => "Generation1",
            _ when number <= 251 => "Generation2",
            _ when number <= 386 => "Generation3",
            _ when number <= 493 => "Generation4",
            _ when number <= 649 => "Generation5",
            _ when number <= 721 => "Generation6",
            _ when number <= 809 => "Generation7",
            _ when number <= 905 => "Generation8",
            _ => "Generation9"
        };
    }
}
