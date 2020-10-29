﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Jint;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace ChromaListe.Generator
{
    [Generator]
    public class PokemonGenerator : ISourceGenerator
    {
        private const string BaseAddress = "https://raw.githubusercontent.com";

        private static readonly Dictionary<string, List<string>> Groups = new()
        {
            ["Regi"] = new List<string> { "377", "378", "379", "486", "894", "895" },
            ["Starter"] = new List<string> { "1", "4", "7", "152", "155", "158", "252", "255", "258", "387", "390", "393", "495", "498", "501", "650", "653", "656", "722", "725", "728", "810", "813", "816" },
            ["Fossil"] = new List<string> { "138", "139", "140", "141", "142", "345", "346", "347", "348", "408", "409", "410", "411", "564", "565", "566", "567", "696", "697", "698", "699", "880", "881", "882", "883", }, //25
            ["Legendary"] = new List<string> { "144", "145", "146", "150", "243", "244", "245", "249", "250", "377", "378", "379", "380", "381", "382", "383", "384", "480", "481", "482", "483", "484", "485", "486", "487", "488", "638", "639", "640", "641", "642", "643", "644", "645", "646", "716", "717", "718", "772", "773", "785", "786", "787", "788", "789", "790", "791", "792", "800", "888", "889", "890", "891", "892", "894", "895", "896", "897", "898", "144g", "145g", "146g" },
            ["Mythical"] = new List<string> { "151", "251", "385", "386", "489", "490", "491", "492", "493", "494", "647", "648", "649", "719", "720", "721", "801", "802", "807", "808", "809", "893" },
            ["Pikalike"] = new List<string> { "25", "26", "26a", "172", "311", "312", "417", "587", "702", "777", "877" },
            ["Eevee"] = new List<string> { "133", "134", "135", "136", "196", "197", "470", "471", "700" },
            ["UltraBeast"] = new List<string> { "793", "794", "795", "796", "797", "798", "799", "803", "804", "805", "806" },
        };

        public void Execute(GeneratorExecutionContext context)
        {
            StringBuilder sourceBuilder = new StringBuilder(@"
// <auto-generated />
using System.Collections.Generic;
namespace ChromaListe.Web.Core
{
    public sealed partial record Pokemon
    {
        private static readonly IReadOnlyDictionary<string, Pokemon> PokemonList = new Dictionary<string, Pokemon>
        {
");
            foreach (string line in GetPokemons())
            {
                sourceBuilder.AppendLine(line);
            }

            // finish creating the source to inject
            sourceBuilder.Append(@"
        };
    }
}");
            context.AddSource("Pokemon.Generated.cs", sourceBuilder.ToString());
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization needed.
        }

        private static List<string> GetPokemons()
        {
            using HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(BaseAddress)
            };

            string textSpecies = client.GetStringAsync(new Uri("kwsch/PKHeX/master/PKHeX.Core/Resources/text/fr/text_Species_fr.txt", UriKind.Relative)).Result;
            string[] lines = textSpecies.Split('\n');
            var names = Enumerable.Range(0, lines.Length).ToDictionary(x => $"{x}", x => lines[x]);

            string pokedexJs = client.GetStringAsync(new Uri("smogon/pokemon-showdown/master/data/pokedex.ts", UriKind.Relative)).Result;

            // Remove all before '"'.
            string minifiedJs = "Pokedex" + pokedexJs.Substring(56);

            object battlePokedex = new Engine()
                .Execute(minifiedJs)
                .GetCompletionValue()
                .ToObject();

            string json = JsonConvert.SerializeObject(battlePokedex);
            IEnumerable<PokemonData>? pokemons = JsonConvert
                .DeserializeObject<IDictionary<string, PokemonData>>(json)
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
                if (pokemon.DisplayNumber == "25a")
                {
                    continue;
                }

                IEnumerable<string> groupsForPokemon = Groups.Where(x => x.Value.Contains(pokemon.DisplayNumber)).Select(x => $"Groups.{x.Key}");
                string groupsString = pokemon.PrimaryGroup;
                if (groupsForPokemon.Any())
                {
                    groupsString += " | " + string.Join(" | ", groupsForPokemon);
                }

                pokemon.FrenchName = names[$"{pokemon.Number}"];
                string line = $@"[""{pokemon.DisplayNumber}""] = new Pokemon(""{pokemon.DisplayNumber}"", ""{pokemon.DisplayName}"", {groupsString}),";
                generatedLines.Add(line);
            }

            return generatedLines;
        }
    }
}
