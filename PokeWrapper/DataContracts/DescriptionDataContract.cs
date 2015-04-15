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
    public class DescriptionDataContract : DataContractBase
    {
        public DescriptionDataContract() { }

        public void SetDescriptionDataContract(DescriptionDataContract descriptionData)
        {
            this.Created = descriptionData.Created;
            this.Description = descriptionData.Description;
            this.GameResourceUriList = descriptionData.GameResourceUriList;
            this.Id = descriptionData.Id;
            this.Modified = descriptionData.Modified;
            this.Name = descriptionData.Name;
            this.PokemonResourceUri = descriptionData.PokemonResourceUri;
            this.ResourceUri = descriptionData.ResourceUri;
        }

        public List<GameDataContract> httpGetGameList()
        {
            List<GameDataContract> gameList = new List<GameDataContract>();
            foreach (var resourceUri in GameResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var game = JsonConvert.DeserializeObject<GameDataContract>(jsonStr);
                gameList.Add(game);

                Debug.WriteLine("Game Id: " + game.Id + ", Game Name: " + game.Name);
            }
            return gameList;
        }

        public PokemonDataContract httpGetPokemon()
        {
            PokemonDataContract pokemon = new PokemonDataContract();
            string jsonStr = base.HttpGet(PokemonResourceUri.ResourceUri);
            pokemon = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);

            Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);

            return pokemon;
        }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "games")]
        public List<ResourceUriDataContract> GameResourceUriList { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public ResourceUriDataContract PokemonResourceUri { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }
    }
}
