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
    public class MoveDataContract : DataContractBase
    {
        public MoveDataContract() { }

        public void SetMoveDataContract(MoveDataContract moveData)
        {
            this.Accuracy = moveData.Accuracy;
            this.Category = moveData.Category;
            this.Created = moveData.Created;
            this.Description = moveData.Description;
            this.Id = moveData.Id;
            this.Modified = moveData.Modified;
            this.Name = moveData.Name;
            this.Power = moveData.Power;
            this.PP = moveData.PP;
            this.ResourceUri = moveData.ResourceUri;
            this.LearnType = moveData.LearnType;
            this.Level = moveData.Level;
        }

        [DataMember(Name = "accuracy")]
        public int Accuracy { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "power")]
        public int Power { get; set; }

        [DataMember(Name = "pp")]
        public int PP { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;

        [DataMember(Name = "learn_type")]
        public string LearnType { get; set; }

        [DataMember(Name = "level")]
        public int? Level { get; set; }
    }
}
