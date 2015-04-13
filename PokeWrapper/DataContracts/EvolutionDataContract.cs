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
    public class EvolutionDataContract : DataContractBase
    {
        public EvolutionDataContract(EvolutionDataContract description)
        {
            try
            {
                string jsonStr = base.HttpGet(description.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(EvolutionDataContract));

                EvolutionDataContract evolutionData = (EvolutionDataContract)jsonSerializer.ReadObject(jsonStream);
                SetEvolutionDataContract(evolutionData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetEvolutionDataContract(EvolutionDataContract evolutionData)
        {
            this.Level = evolutionData.Level;
            this.Method = evolutionData.Method;
            this.To = evolutionData.To;
            this.ResourceUri = evolutionData.ResourceUri;
            
            // Games
        }

        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }

        [DataMember(Name = "to")]
        public string To { get; set; }
    }
}
