using PokeWrapper.DataContacts;
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

namespace PokeWrapper.TaskRunners
{
    /// <summary>
    /// Easy way to generate C# objects from json : http://json2csharp.com/
    /// </summary>
    class PokemonTaskRunner
    {
        static void Main(string[] args)
        {            
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://pokeapi.co/api/v1/");

            httpClient.MaxResponseContentBufferSize = 256000;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                for (int i = 1; i < 2; i++)
                {
                    HttpResponseMessage response = await httpClient.GetAsync("pokemon/" + i);
                    response.EnsureSuccessStatusCode();

                    var jsonStr = response.Content.ReadAsStringAsync().Result;
                    MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokemonDataContract));

                    PokemonDataContract p = (PokemonDataContract)jsonSerializer.ReadObject(jsonStream);

                    Console.WriteLine(p.Name + " " + p.Abilities[0].Name);
                }
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
    }
}
