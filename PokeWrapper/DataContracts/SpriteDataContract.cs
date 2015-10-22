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
    public class SpriteDataContract : DataContractBase
    {
        public SpriteDataContract() { }
        
        public void SetSpriteDataContract(SpriteDataContract spriteData)
        {
            this.Created = spriteData.Created;
            this.Id = spriteData.Id;
            this.Image = spriteData.Image;
            this.Modified = spriteData.Modified;
            this.Name = spriteData.Name;
            this.PokemonResourceUri = spriteData.PokemonResourceUri;
            this.Name = spriteData.Name;
            this.SpriteResourceUri = spriteData.SpriteResourceUri;
        }

        public PokemonDataContract httpGetPokemon()
        {
            PokemonDataContract pokemon = new PokemonDataContract();
            string jsonStr = base.HttpGet(PokemonResourceUri.ResourceUri);
            pokemon = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);

            Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);

            return pokemon;
        }

        public SpriteDataContract httpGetSprite()
        {
            SpriteDataContract sprite = new SpriteDataContract();
            string jsonStr = base.HttpGet(SpriteResourceUri);
            sprite = JsonConvert.DeserializeObject<SpriteDataContract>(jsonStr);

            Debug.WriteLine("Pokemon Id: " + sprite.Id + ", Pokemon Name: " + sprite.Name);

            return sprite;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "pokemon")]
        public ResourceUriDataContract PokemonResourceUri { get; set; }

        [DataMember(Name = "resource_uri")]
        public string SpriteResourceUri;
    }
}
