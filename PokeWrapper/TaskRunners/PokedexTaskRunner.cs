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
            PokedexDataContract pokedex = new PokedexDataContract();
            HttpGetPokedex(ref pokedex);

            List<PokemonDataContract> pokemonList = pokedex.pokemon;
            HttpGetPokemon(pokemonList);

            pokedex.pokemon = pokemonList.OrderBy(p => p.PkdxId).ToList();

            foreach(PokemonDataContract pokemon in pokedex.pokemon) {
                Debug.WriteLine(pokemon.PkdxId + ": " + pokemon.Name);
            };
        }

        public static void HttpGetPokedex(ref PokedexDataContract pokedex)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://pokeapi.co/api/v1/");

            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = httpClient.GetAsync("pokedex/1").Result;
                response.EnsureSuccessStatusCode();

                var jsonStr = response.Content.ReadAsStringAsync().Result;
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokedexDataContract));

                pokedex = (PokedexDataContract)jsonSerializer.ReadObject(jsonStream);
            }
            catch (HttpRequestException hre)
            {
                Console.WriteLine(hre.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        public static void HttpGetPokemon(List<PokemonDataContract> pokemonList)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://pokeapi.co/");

            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                for (int i = 0; i < pokemonList.Count; i++)
                {
                    HttpResponseMessage response = httpClient.GetAsync(pokemonList[i].ResourceUri).Result;
                    response.EnsureSuccessStatusCode();

                    var jsonStr = response.Content.ReadAsStringAsync().Result;
                    MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokemonDataContract));

                    pokemonList[i] = (PokemonDataContract)jsonSerializer.ReadObject(jsonStream);
                    
                    Debug.WriteLine("Count " + i + ", Pokemon: " + pokemonList[i].Name);
                }
            }
            catch (HttpRequestException hre)
            {
                throw hre;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
