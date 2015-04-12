using PokeWrapper.DataContacts;
using System;
using System.Collections.Generic;
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
        public DescriptionDataContract(DescriptionDataContract description)
        {
            this.Games = new List<GameDataContract>();

            try
            {
                string jsonStr = base.HttpGet(description.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DescriptionDataContract));

                DescriptionDataContract descriptionData = (DescriptionDataContract)jsonSerializer.ReadObject(jsonStream);
                SetDescriptionDataContract(descriptionData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetDescriptionDataContract(DescriptionDataContract descriptionData)
        {
            this.Created = descriptionData.Created;
            this.Description = descriptionData.Description;
            this.Id = descriptionData.Id;
            this.Modified = descriptionData.Modified;
            this.Name = descriptionData.Name;
            this.Pokemon = descriptionData.Pokemon;
            this.ResourceUri = descriptionData.ResourceUri;
            
            // Games
        }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "games")]
        public List<GameDataContract> Games { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "pokemon")]
        public PokemonDataContract Pokemon { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }
    }
}
