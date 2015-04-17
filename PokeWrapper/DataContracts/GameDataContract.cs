using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class GameDataContract : DataContractBase
    {
        public void SetGameDataContract(GameDataContract gameData)
        {
            this.Created = gameData.Created;
            this.Generation = gameData.Generation;
            this.Id = gameData.Id;
            this.Modified = gameData.Modified;
            this.Name = gameData.Name;
            this.ReleaseYear = gameData.ReleaseYear;
            this.GameResourceUri = this.GameResourceUri;
        }

        public GameDataContract httpGetGame()
        {
            GameDataContract game = new GameDataContract();
            string jsonStr = base.HttpGet(GameResourceUri);
            game = JsonConvert.DeserializeObject<GameDataContract>(jsonStr);

            Debug.WriteLine("Game Id: " + game.Id + ", Game Name: " + game.Name);

            return game;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "generation")]
        public int Generation { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "release_year")]
        public int ReleaseYear { get; set; }

        [DataMember(Name = "resource_uri")]
        public string GameResourceUri { get; set; }

    }
}
