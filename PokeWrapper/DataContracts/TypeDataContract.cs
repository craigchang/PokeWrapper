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
    public class TypeDataContract : DataContractBase
    {
        public TypeDataContract(TypeDataContract move)
        {
            try
            {
                string jsonStr = base.HttpGet(move.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TypeDataContract));

                TypeDataContract typeData = (TypeDataContract)jsonSerializer.ReadObject(jsonStream);
                SetTypeDataContract(typeData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetTypeDataContract(TypeDataContract typeData)
        {
            this.Created = typeData.Created;
            this.Id = typeData.Id;
            this.Created = typeData.Created;
            this.Modified = typeData.Modified;
            this.Name = typeData.Name;
            this.Modified = typeData.Modified;
            this.Name = typeData.Name;
            this.ResourceUri = typeData.ResourceUri;

            // ineffective list
            // noeffect list
            // resistence list
            // supereffective list
            // weakness list
        }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "ineffective")]
        public List<TypeDataContract> Ineffective { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "no_effect")]
        public List<TypeDataContract> NoEffect { get; set; }

        [DataMember(Name = "resistance")]
        public List<TypeDataContract> Resistance { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;

        [DataMember(Name = "super_effective")]
        public List<TypeDataContract> SuperEffective { get; set; }

        [DataMember(Name = "weakness")]
        public List<TypeDataContract> Weakness { get; set; }
    }
}
