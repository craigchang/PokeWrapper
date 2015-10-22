using Newtonsoft.Json;
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
            this.EggGroupResourceUri = eggGroupData.EggGroupResourceUri;
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

        public EggGroupDataContract httpGetEggGroup()
        {
            EggGroupDataContract eggGroup = new EggGroupDataContract();
            string jsonStr = base.HttpGet(EggGroupResourceUri);
            eggGroup = JsonConvert.DeserializeObject<EggGroupDataContract>(jsonStr);

            Debug.WriteLine("Egg Group Id: " + eggGroup.Id + ", Egg Group Name: " + eggGroup.Name);

            return eggGroup;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public List<ResourceUriDataContract> PokemonResourceUriList { get; set; }

        [DataMember(Name = "resource_uri")]
        public string EggGroupResourceUri;
    }
}
