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
    public class EvolutionDataContract : DataContractBase
    {
        public EvolutionDataContract() { }

        public void SetEvolutionDataContract(EvolutionDataContract evolutionData)
        {
            this.Level = evolutionData.Level;
            this.Method = evolutionData.Method;
            this.To = evolutionData.To;
            this.ResourceUri = evolutionData.ResourceUri;
        }

        public PokemonDataContract httpGetPokemon()
        {
            PokemonDataContract pokemon = new PokemonDataContract();
            string jsonStr = base.HttpGet(ResourceUri);
            pokemon = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);

            Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);

            return pokemon;
        }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "resource_uri")] // pokemon resourceUri
        public string ResourceUri { get; set; }

        [DataMember(Name = "to")]
        public string To { get; set; }
    }
}
