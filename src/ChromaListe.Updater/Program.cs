using System.Globalization;
using System.Text.Json;
using ChromaListe.Updater;
using Jint;

const string BaseAddress = "https://raw.githubusercontent.com";

using HttpClient client = new()
{
    BaseAddress = new Uri(BaseAddress)
};

string[] nameLines = await File.ReadAllLinesAsync("names.txt");
var names = Enumerable.Range(0, nameLines.Length).Where(x => !string.IsNullOrWhiteSpace(nameLines[x])).ToDictionary(x => x + 1, x => nameLines[x]);

string[] typeLines = await File.ReadAllLinesAsync("types.csv");
var types = Enumerable
    .Range(0, typeLines.Length)
    .Where(x => !string.IsNullOrWhiteSpace(typeLines[x]))
    .ToDictionary(x => typeLines[x].Split(',')[0], x => typeLines[x].Split(',')[1]);

string pokedexJs = await client.GetStringAsync(new Uri("smogon/pokemon-showdown/master/data/pokedex.ts", UriKind.Relative));

// Remove all before '"'.
string minifiedJs = $"Pokedex{pokedexJs.AsSpan(56)}";

using var engine = new Engine();
object battlePokedex = engine
    .Evaluate(minifiedJs)
    .ToObject()!;

string json = JsonSerializer.Serialize(battlePokedex);
ICollection<PokemonData>? pokemons = JsonSerializer
    .Deserialize<IDictionary<string, PokemonData>>(json)
    ?.Values
    .Where(x => x.Number > 0 && new[] { null, "Alola", "Galar", "Hisui", "Paldea", "Paldea-Combat" }.Contains(x.Form))
    .ToList();
if (pokemons is null)
{
    throw new InvalidOperationException("pokemons");
}

var pokemonByGame = new Dictionary<(int number, string? form), string>();
string[] locations = await File.ReadAllLinesAsync("locations.csv");
foreach (string location in locations)
{
    string[] parts = location.Split(',');
    pokemonByGame.Add((int.Parse(parts[0], NumberStyles.Integer, CultureInfo.InvariantCulture), parts[1].Length is 0 ? null : parts[1]), parts[2]);
}

List<string> generatedLines = [];
foreach (PokemonData pokemon in pokemons)
{
    // Skip Pikachu alola, because it's the pikachu with the alola cap.
    if (pokemon.Number == 25 && pokemon.Form == "Alola")
    {
        continue;
    }

    // All paldean tauros form are suffixed with the type so the "basic" one is taken as the paldean form.
    if (pokemon.Form == "Paldea-Combat")
    {
        pokemon.Form = "Paldea";
    }

    // Basculegion pre evolution form is excluded by default, so it is renamed to Basculin.
    if (pokemon.PreEvolution == "Basculin-White-Striped")
    {
        pokemon.PreEvolution = "Basculin";
    }

    // DLC paradox pokémon do not have tags
    if (pokemon.Number is >= 1020 and <= 1023)
    {
        pokemon.Tags = ["Paradox"];
    }

    // Melmetal do not have any relation to Meltan in the data
    if (pokemon.Number is 809)
    {
        pokemon.SpeciesNumber = 808;
    }
    else if (string.IsNullOrWhiteSpace(pokemon.BaseName) && string.IsNullOrWhiteSpace(pokemon.PreEvolution))
    {
        pokemon.SpeciesNumber = pokemon.Number;
    }
    else if (!string.IsNullOrWhiteSpace(pokemon.BaseName))
    {
        pokemon.SpeciesNumber = pokemons.Single(p => p.Name == pokemon.BaseName).SpeciesNumber;
    }
    else if (!string.IsNullOrWhiteSpace(pokemon.PreEvolution))
    {
        pokemon.SpeciesNumber = pokemons.Single(p => p.Name == pokemon.PreEvolution).SpeciesNumber;

        // Handle cases when the pre-evolution is in a more recent gen
        if (pokemon.SpeciesNumber is 0)
        {
            pokemon.SpeciesNumber = pokemons.Single(p => p.Name == pokemon.PreEvolution).Number;
        }
    }

    pokemon.TranslatedName = names.GetValueOrDefault(pokemon.Number, pokemon.BaseName ?? pokemon.Name);
    string primaryType = types.GetValueOrDefault(pokemon.PrimaryType, pokemon.PrimaryType);
    string? secondaryType = pokemon.SecondaryType is not null ? types.GetValueOrDefault(pokemon.SecondaryType, pokemon.SecondaryType) : null;
    generatedLines.Add($"{pokemon.Number},{pokemon.TranslatedName},{pokemon.Form},{primaryType},{secondaryType},{pokemon.TagList},{pokemon.SpeciesNumber},{pokemonByGame[(pokemon.Number, pokemon.Form)]}");
}

await File.WriteAllLinesAsync("../ChromaListe.Web/pokemons.csv", generatedLines);
