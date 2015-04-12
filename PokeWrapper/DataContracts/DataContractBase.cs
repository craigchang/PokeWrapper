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

        public string HttpGet(string url) {
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

        public HttpClient getHttpClient()
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
