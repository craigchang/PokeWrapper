using Newtonsoft.Json;
using PokeWrapper.DataContacts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class EggGroupDataContract : DataContractBase
    {
        public EggGroupDataContract() { }

        public void SetEggGroupDataContract(EggGroupDataContract eggGroupData)
        {
            this.Created = eggGroupData.Created;
            this.Id = eggGroupData.Id;
            this.Modified = eggGroupData.Modified;
            this.Name = eggGroupData.Name;
            this.PokemonResourceUriList = eggGroupData.PokemonResourceUriList;
            this.ResourceUri = eggGroupData.ResourceUri;
        }

        public List<PokemonDataContract> httpGetPokemonList()
        {
            List<PokemonDataContract> pokemonList = new List<PokemonDataContract>();
            foreach (var resourceUri in PokemonResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var pokemon = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);
                pokemonList.Add(pokemon);

                Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);
            }
            return pokemonList;
        }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public List<ResourceUriDataContract> PokemonResourceUriList { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
