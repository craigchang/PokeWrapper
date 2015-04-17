using Newtonsoft.Json;
using PokeWrapper.DataContacts;
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

namespace PokeWrapper.DataContracts
{
    public static class DataContractGenerator
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
        private static DataContractBase dcb;
        private static HttpClient pokeApiHttpClient = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();

        public static DataContractBase getInstance(DataContractType dataContractType,  int id)
        {
            try
            {
                switch (dataContractType)
                {
                    case DataContractType.Pokedex:
                        jsonStr = HttpGet(PokedexRelativeUrl);
                        dcb = JsonConvert.DeserializeObject<PokedexDataContract>(jsonStr);
                        break;
                    case DataContractType.Pokemon:
                        jsonStr = HttpGet(PokemonRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);
                        break;
                    case DataContractType.Ability:
                        jsonStr = HttpGet(AbilityRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<AbilityDataContract>(jsonStr);
                        break;
                    case DataContractType.Description:
                        jsonStr = HttpGet(DescriptionRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<DescriptionDataContract>(jsonStr);
                        break;
                    case DataContractType.EggGroup:
                        jsonStr = HttpGet(EggGroupRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<EggGroupDataContract>(jsonStr);
                        break;
                    case DataContractType.Move:
                        jsonStr = HttpGet(MoveRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<MoveDataContract>(jsonStr);
                        break;
                    case DataContractType.Sprite:
                        jsonStr = HttpGet(SpriteRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<SpriteDataContract>(jsonStr);
                        break;
                    case DataContractType.Game:
                        jsonStr = HttpGet(GameRelativeUrl + id);
                        dcb = JsonConvert.DeserializeObject<GameDataContract>(jsonStr);
                        break;
                    default:
                        dcb = null;
                        break;
                }
            }
            catch (HttpRequestException hre)
            {
                Debug.WriteLine("Exception detected: " + hre.StackTrace);
                return null;
            }

            return dcb;
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
            pokeApiHttpClient.BaseAddress = new Uri(BaseUrl);

            pokeApiHttpClient.MaxResponseContentBufferSize = 256000;
            pokeApiHttpClient.DefaultRequestHeaders.Accept.Clear();
            pokeApiHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return pokeApiHttpClient;
        }
    }
}
