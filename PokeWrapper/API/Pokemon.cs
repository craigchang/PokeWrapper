using Newtonsoft.Json;
using PokeWrapper.DataContacts;
using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.API
{
    public class Pokemon
    {
        private const string BaseUrl = "http://pokeapi.co/";
        private const string PokemonRelativeUrl = "api/v1/pokemon/";

        private static string jsonStr;
        private static HttpClient pokeApiHttpClient = new HttpClient();
        private static HttpResponseMessage response = new HttpResponseMessage();
        private static MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");

        public static PokemonDataContract getInstance(int id)
        {
            try
            {
                jsonStr = HttpGet(PokemonRelativeUrl + id);
                return JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);
            }
            catch (HttpRequestException hre)
            {
                Debug.WriteLine("Exception detected: " + hre.StackTrace);
                return null;
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
