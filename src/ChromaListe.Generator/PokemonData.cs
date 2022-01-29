namespace ChromaListe.Generator;

public class PokemonData
{
    public PokemonData(double number, string name, string form, string primaryTpe, string? secondaryTpe, string? tag)
    {
        Number = number;
        Name = name;
        Form = form;
        PrimaryTpe = primaryTpe;
        SecondaryTpe = secondaryTpe;
        Tag = tag;
    }

    public double Number { get; set; }

    public string Name { get; set; }

    public string Form { get; set; }

    public string PrimaryTpe { get; set; }

    public string? SecondaryTpe { get; set; }

    public string? Tag { get; set; }

    public string DisplayName => Form switch
    {
        "Alola" => $"{Name} (Alola)",
        "Galar" => $"{Name} (Galar)",
        "Hisui" => $"{Name} (Hisui)",
        _ => Name,
    };

    public string PrimaryGroup => Form switch
    {
        "Alola" => "Groups.Alola",
        "Galar" => "Groups.Galar",
        "Hisui" => "Groups.Hisui",
        _ => $"Groups.{GetGeneration((int)Number)}",
    };

    public string DisplayNumber => Form switch
    {
        "Alola" => $"{Number}a",
        "Galar" => $"{Number}g",
        "Hisui" => $"{Number}h",
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
            _ => "Generation8"
        };
    }
}
