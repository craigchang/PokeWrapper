using Newtonsoft.Json;
using PokeWrapper.DataContacts;
using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.API
{
    public static class DataContractGenerator<T>
    {
        private const string BaseUrl = "http://pokeapi.co/";
        private const string PokedexRelativeUrl = "api/v1/pokedex/1";
        private const string PokemonRelativeUrl = "api/v1/pokemon/";
        private const string TypeRelativeUrl = "api/v1/type/";
        private const string MoveRelativeUrl = "api/v1/move/";
        private const string AbilityRelativeUrl = "api/v1/ability/";
        private const string EggGroupRelativeUrl = "api/v1/egg/";
        private const string DescriptionRelativeUrl = "api/v1/description/";
        private const string SpriteRelativeUrl = "api/v1/sprite/";
        private const string GameRelativeUrl = "api/v1/game/";

        private static string jsonStr;
        private static HttpClient pokeApiHttpClient = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();
        private static MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");

        public static T getInstance(int id)
        {
            try
            {
                if (typeof(PokedexDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(PokedexRelativeUrl);
                else if (typeof(PokemonDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(PokemonRelativeUrl);
                else if (typeof(TypeDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(TypeRelativeUrl);
                else if (typeof(AbilityDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(AbilityRelativeUrl);
                else if (typeof(DescriptionDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(DescriptionRelativeUrl);
                else if (typeof(EggGroupDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(EggGroupRelativeUrl);
                else if (typeof(MoveDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(MoveRelativeUrl);
                else if (typeof(SpriteDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(SpriteRelativeUrl);
                else if (typeof(GameDataContract).IsAssignableFrom(typeof(T)))
                    jsonStr = HttpGet(GameRelativeUrl);
                else
                    throw new Exception("Invalid Data Contract!");

                return JsonConvert.DeserializeObject<T>(jsonStr);
            }
            catch (HttpRequestException hre)
            {
                Debug.WriteLine("Exception detected: " + hre.StackTrace);
                return default(T);
            }
        }

        private static string HttpGet(string url)
        {
            try
            {
                pokeApiHttpClient = getHttpClientSettings();
                response = pokeApiHttpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
            catch (HttpRequestException hre)
            {
                throw hre;
            }
            finally
            {
            }
        }

        private static HttpClient getHttpClientSettings()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);

            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(mediaType);

            return httpClient;
        }
    }
}
