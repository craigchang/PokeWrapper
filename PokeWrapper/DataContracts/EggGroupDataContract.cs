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
    public class EggGroupDataContract : DataContractBase
    {
        public EggGroupDataContract(EggGroupDataContract description)
        {
            this.Pokemon = new List<PokemonDataContract>();

            try
            {
                string jsonStr = base.HttpGet(description.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(EggGroupDataContract));

                EggGroupDataContract eggGroupData = (EggGroupDataContract)jsonSerializer.ReadObject(jsonStream);
                SetEggGroupDataContract(eggGroupData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetEggGroupDataContract(EggGroupDataContract eggGroupData)
        {
            this.Created = eggGroupData.Created;
            this.Id = eggGroupData.Id;
            this.Modified = eggGroupData.Modified;
            this.Name = eggGroupData.Name;
            this.Pokemon = eggGroupData.Pokemon;
            this.ResourceUri = eggGroupData.ResourceUri;
            
            // Games
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
        public List<PokemonDataContract> Pokemon { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
