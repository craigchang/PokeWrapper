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
    public class SpriteDataContract : DataContractBase
    {
        public SpriteDataContract(SpriteDataContract move)
        {
            try
            {
                string jsonStr = base.HttpGet(move.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(SpriteDataContract));

                SpriteDataContract spriteData = (SpriteDataContract)jsonSerializer.ReadObject(jsonStream);
                SetSpriteDataContract(spriteData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetSpriteDataContract(SpriteDataContract spriteData)
        {
            this.Created = spriteData.Created;
            this.Id = spriteData.Id;
            this.Image = spriteData.Image;
            this.Modified = spriteData.Modified;
            this.Name = spriteData.Name;
            this.PokemonResourceUri = spriteData.PokemonResourceUri;
            this.Name = spriteData.Name;
            this.ResourceUri = spriteData.ResourceUri;
        }

        public PokemonDataContract httpGetPokemon()
        {
            PokemonDataContract pokemon = new PokemonDataContract();
            string jsonStr = base.HttpGet(PokemonResourceUri.ResourceUri);
            MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokemonDataContract));

            pokemon = (PokemonDataContract)jsonSerializer.ReadObject(jsonStream);

            Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);

            return pokemon;
        }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "pokemon")]
        public ResourceUriDataContract PokemonResourceUri { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
