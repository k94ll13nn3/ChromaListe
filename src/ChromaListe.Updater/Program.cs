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
string minifiedJs = string.Concat("Pokedex", pokedexJs.AsSpan(56));

object battlePokedex = new Engine()
    .Execute(minifiedJs)
    .GetCompletionValue()
    .ToObject();

string json = JsonSerializer.Serialize(battlePokedex);
IEnumerable<PokemonData>? pokemons = JsonSerializer
    .Deserialize<IDictionary<string, PokemonData>>(json)
    ?.Values
    .Where(x => x.Number > 0 && new[] { string.Empty, "Alola", "Galar" }.Contains(x.Form));
if (pokemons is null)
{
    throw new InvalidOperationException("pokemons");
}

List<string> generatedLines = new();
foreach (PokemonData pokemon in pokemons)
{
    // Skip Pikachu alola, because it's the pikachu with the alola cap.
    if (pokemon.Number == 25 && pokemon.Form == "Alola")
    {
        continue;
    }

    pokemon.Name = names.GetValueOrDefault((int)pokemon.Number, pokemon.BaseName ?? pokemon.Name);
    string primaryType = types.GetValueOrDefault(pokemon.PrimaryType, pokemon.PrimaryType);
    string? secondaryType = pokemon.SecondaryType is not null ? types.GetValueOrDefault(pokemon.SecondaryType, pokemon.SecondaryType) : null;
    generatedLines.Add($"{pokemon.Number},{pokemon.Name},{pokemon.Form},{primaryType},{secondaryType},{pokemon.PrimaryTag}");
}

await File.WriteAllLinesAsync("../ChromaListe.Web/pokemons.csv", generatedLines);
