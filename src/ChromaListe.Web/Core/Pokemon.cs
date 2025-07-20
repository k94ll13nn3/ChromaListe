namespace ChromaListe.Web.Core;

public sealed partial record Pokemon
{
    private static readonly IDictionary<string, Pokemon> PokemonList = new Dictionary<string, Pokemon>();

    private Pokemon(string number, string name, string primaryType, string? secondaryType, Groups groups, double speciesNumber, Dictionary<string, int> games)
    {
        Number = number;
        Name = name;
        PrimaryType = primaryType;
        SecondaryType = secondaryType;
        Groups = groups;
        SpeciesNumber = speciesNumber;
        Games = games;
    }

    public static int PokemonCount => PokemonList.Count;

    public string Name { get; }

    public string Number { get; }

    public double SpeciesNumber { get; }

    public string PrimaryType { get; }

    public string? SecondaryType { get; }

    public string PaddedNumber => Number.PadLeft(Number.EndsWith('a') || Number.EndsWith('g') || Number.EndsWith('h') || Number.EndsWith('p') ? 5 : 4, '0');

    public Groups Groups { get; }

    public Dictionary<string, int> Games { get; }

    public static Pokemon Get(string number)
    {
        return PokemonList[number];
    }

    public static ICollection<Pokemon> GetAll()
    {
        return PokemonList.Values;
    }

    public static IReadOnlyCollection<Pokemon> GetAll(Groups group)
    {
        return [.. PokemonList.Values.Where(p => p.Groups.HasFlag(group))];
    }
}
