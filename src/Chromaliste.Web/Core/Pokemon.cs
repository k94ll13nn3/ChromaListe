using System.Collections.Generic;
using System.Linq;

namespace ChromaListe.Web.Core
{
    public sealed partial record Pokemon
    {
        private Pokemon(string number, string name, Groups groups)
        {
            Number = number;
            Name = name;
            Groups = groups;
        }

        public static int PokemonCount => PokemonList.Count;

        public string Name { get; }

        public string Number { get; }

        public string PaddedNumber => Number.PadLeft(Number.EndsWith('a') || Number.EndsWith('g') ? 5 : 4, '0');

        public Groups Groups { get; }

        public static Pokemon Get(string number)
        {
            return PokemonList[number];
        }

        public static IEnumerable<Pokemon> GetAll()
        {
            return PokemonList.Values;
        }

        public static IEnumerable<Pokemon> GetAll(Groups group)
        {
            return PokemonList.Values.Where(p => p.Groups.HasFlag(group));
        }
    }
}
