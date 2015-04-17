using Newtonsoft.Json;
using PokeWrapper.DataContacts;
using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.TaskRunners
{
    class PokedexTaskRunner
    {
        static void Main(string[] args)
        {
            PokedexDataContract pokedex = (PokedexDataContract) DataContractGenerator.getInstance(DataContractType.Pokedex, 1);

            List<PokemonDataContract> pokemonList = pokedex.httpGetPokemonList();

            foreach (PokemonDataContract pokemon in pokemonList)
            {
                List<AbilityDataContract> abilities = pokemon.httpGetPokemonAbilities();
                List<DescriptionDataContract> descriptions = pokemon.httpGetPokemonDescriptions();
                List<EggGroupDataContract> eggGroups = pokemon.httpGetPokemonEggGroups();
                List<MoveDataContract> moves = pokemon.httpGetPokemonMoves();
                List<SpriteDataContract> sprites = pokemon.httpGetPokemonSprites();
                List<TypeDataContract> types = pokemon.httpGetPokemonTypes();
            }
        }
    }
}
