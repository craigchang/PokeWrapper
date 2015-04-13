using PokeWrapper.DataContacts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class PokedexDataContract : DataContractBase
    {
        public PokedexDataContract() {
            this.PokemonResourceUriList = new List<ResourceUriDataContract>();

            string jsonStr = base.HttpGet("api/v1/pokedex/1");
            MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokedexDataContract));

            jsonSerializer = new DataContractJsonSerializer(typeof(PokedexDataContract));
            var pokedex = (PokedexDataContract)jsonSerializer.ReadObject(jsonStream);
            SetPokedexDataContract((PokedexDataContract)pokedex);

            Debug.WriteLine("Pokedex Name: " + pokedex.Name);
        }

        public void SetPokedexDataContract(PokedexDataContract pokedex) {
            this.Created = pokedex.Created;
            this.Modified = pokedex.Modified;
            this.Name = pokedex.Name;
            this.ResourceUri = pokedex.ResourceUri;
            this.PokemonResourceUriList = pokedex.PokemonResourceUriList;
        }

        public List<PokemonDataContract> httpGetPokemonList()
        {
            List<PokemonDataContract> pokemonList = new List<PokemonDataContract>();
            foreach (var resourceUri in PokemonResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokemonDataContract));
                
                var pokemon = (PokemonDataContract)jsonSerializer.ReadObject(jsonStream);
                pokemonList.Add(pokemon);

                Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);
            }
            return pokemonList;
        }

        //public void sortPokemonList()
        //{
        //    this.PokemonList = this.PokemonList.OrderBy(p => p.PkdxId).ToList();
        //}

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public List<ResourceUriDataContract> PokemonResourceUriList { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }
    }
}
