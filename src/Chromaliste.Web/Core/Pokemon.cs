using System.Collections.Generic;
using System.Linq;

namespace ChromaListe.Web.Core
{
    public sealed partial record Pokemon
    {
        private Pokemon(string number, string name, Groups groups, Type primaryType, Type? secondaryType)
        {
            Number = number;
            Name = name;
            Groups = groups;
            PrimaryType = primaryType;
            SecondaryType = secondaryType;
        }

        public static int PokemonCount => PokemonList.Count;

        public string Name { get; }

        public string Number { get; }

        public Groups Groups { get; }

        public Type PrimaryType { get; }

        public Type? SecondaryType { get; }

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
