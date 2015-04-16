using Newtonsoft.Json;
using PokeWrapper.DataContacts;
using System;
using System.Collections.Generic;
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
        private static string jsonStr;
        private static MemoryStream jsonStream;
        private static DataContractJsonSerializer jsonSerializer;
        private static DataContractBase dcb;

        public static DataContractBase getInstance(string dataContractType,  string url)
        {
            switch (dataContractType)
            {
                case "Pokedex":
                    jsonStr = HttpGet("api/v1/pokedex/1");
                    dcb = JsonConvert.DeserializeObject<PokedexDataContract>(jsonStr);
                    break;
                case "Pokemon":
                    jsonStr = HttpGet(url);
                    dcb = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);
                    break;
                case "Ability":
                    jsonStr = HttpGet(url);
                    dcb = JsonConvert.DeserializeObject<AbilityDataContract>(jsonStr);
                    break;
                case "Description":
                    jsonStr = HttpGet(url);
                    dcb = JsonConvert.DeserializeObject<DescriptionDataContract>(jsonStr);
                    break;
                case "EggGroup":
                    jsonStr = HttpGet(url);
                    dcb = JsonConvert.DeserializeObject<EggGroupDataContract>(jsonStr);
                    break;
                case "Move":
                    jsonStr = HttpGet(url);
                    dcb = JsonConvert.DeserializeObject<MoveDataContract>(jsonStr);
                    break;
                default:
                    dcb = null;
                    break;
            }

            return dcb;
        }

        private static string HttpGet(string url)
        {
            HttpClient httpClient = getHttpClient();

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (HttpRequestException hre)
            {
                throw hre;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }
        }

        private static HttpClient getHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);

            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }
    }
}
