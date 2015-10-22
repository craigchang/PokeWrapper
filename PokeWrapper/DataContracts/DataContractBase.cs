using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public abstract class DataContractBase
    {
        public const string BaseUrl = "http://pokeapi.co/";
        private const int MaxResponseContentBufferSize = 256000;

        private HttpResponseMessage response;
        private HttpClient pokeApiHttpClient;
        private static MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");

        public DataContractBase(){}

        public string HttpGet(string url) {
            
            try
            {
                pokeApiHttpClient = this.getHttpClientSettings();
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

        public HttpClient getHttpClientSettings()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);

            httpClient.MaxResponseContentBufferSize = MaxResponseContentBufferSize;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(mediaType);

            return httpClient;
        }      
    }
}
