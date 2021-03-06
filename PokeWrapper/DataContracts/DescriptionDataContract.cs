﻿using Newtonsoft.Json;
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
            this.DescriptionResourceUri = descriptionData.DescriptionResourceUri;
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

        public DescriptionDataContract httpGetDescription()
        {
            DescriptionDataContract description = new DescriptionDataContract();
            string jsonStr = base.HttpGet(DescriptionResourceUri);
            description = JsonConvert.DeserializeObject<DescriptionDataContract>(jsonStr);

            Debug.WriteLine("Description Id: " + description.Id + ", Description Name: " + description.Name);

            return description;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "games")]
        public List<ResourceUriDataContract> GameResourceUriList { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public ResourceUriDataContract PokemonResourceUri { get; set; }

        [DataMember(Name = "resource_uri")]
        public string DescriptionResourceUri { get; set; }
    }
}
