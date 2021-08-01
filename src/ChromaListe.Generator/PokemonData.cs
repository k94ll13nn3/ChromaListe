using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace ChromaListe.Generator
{
    public class PokemonData
    {
        [JsonProperty("num")]
        public double Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("baseSpecies")]
        public string BaseName { get; set; } = string.Empty;

        public string FrenchName { get; set; } = string.Empty;

        [JsonProperty("forme")]
        public string Form { get; set; } = string.Empty;

        [JsonProperty("types")]
        [SuppressMessage("Usage", "CA2227", Justification = "Used only for serialization.")]
        public IList<string> Types { get; set; } = new List<string>();

        public string DisplayName => Form switch
        {
            "Alola" => $"{FrenchName} (Alola)",
            "Galar" => $"{FrenchName} (Galar)",
            _ => FrenchName,
        };

        public string PrimaryGroup => Form switch
        {
            "Alola" => "Groups.Alola",
            "Galar" => "Groups.Galar",
            _ => $"Groups.{GetGeneration((int)Number)}",
        };

        public string DisplayNumber => Form switch
        {
            "Alola" => $"{Number}a",
            "Galar" => $"{Number}g",
            _ => $"{Number}",
        };

        public string PrimaryTpe => $"PokemonType.{Types[0]}";

        public string? SecondaryTpe => Types.Count > 1 ? $"PokemonType.{Types[1]}" : "null";

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
}
