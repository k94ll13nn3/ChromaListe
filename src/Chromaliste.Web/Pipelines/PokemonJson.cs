using Statiq.Common;
using Statiq.Core;
using Statiq.Json;

namespace Chromaliste.Web.Pipelines
{
    public class PokemonJson : Pipeline
    {
        public PokemonJson()
        {
            InputModules = new ModuleList
            {
                new ReadFiles("data/pokemons.json")
            };

            ProcessModules = new ModuleList
            {
                new ParseJson()
            };
        }
    }
}