using System.Text.Json;
using ChromaListe.Updater;
using Jint;

const string BaseAddress = "https://raw.githubusercontent.com";

using HttpClient client = new()
{
    BaseAddress = new Uri(BaseAddress)
};

string[] lines = await File.ReadAllLinesAsync("french.txt");
var names = Enumerable.Range(0, lines.Length).Where(x => !string.IsNullOrWhiteSpace(lines[x])).ToDictionary(x => x + 1, x => lines[x]);

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
    generatedLines.Add($"{pokemon.Number},{pokemon.Name},{pokemon.Form},{pokemon.PrimaryType},{pokemon.SecondaryType},{pokemon.PrimaryTag}");
}

await File.WriteAllLinesAsync("../ChromaListe.Web/pokemons.csv", generatedLines);
