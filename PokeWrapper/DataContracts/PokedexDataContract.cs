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
using System.Threading.Tasks;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class PokedexDataContract : DataContractBase
    {
        public PokedexDataContract() { }

        public void SetPokedexDataContract(PokedexDataContract pokedex) {
            this.Created = pokedex.Created;
            this.Modified = pokedex.Modified;
            this.Name = pokedex.Name;
            this.PokedexResourceUri = pokedex.PokedexResourceUri;
            this.PokemonResourceUriList = pokedex.PokemonResourceUriList;
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

        public PokedexDataContract httpGetPokedex()
        {
            PokedexDataContract pokedex = new PokedexDataContract();
            string jsonStr = base.HttpGet(PokedexResourceUri);
            pokedex = JsonConvert.DeserializeObject<PokedexDataContract>(jsonStr);

            Debug.WriteLine("Pokedex Id: " + 1 + ", Pokedex Name: " + pokedex.Name);

            return pokedex;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public List<ResourceUriDataContract> PokemonResourceUriList { get; set; }

        [DataMember(Name = "resource_uri")]
        public string PokedexResourceUri { get; set; }
    }
}
