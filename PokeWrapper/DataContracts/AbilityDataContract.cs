﻿using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PokeWrapper.DataContacts
{
    [DataContract]
    public class AbilityDataContract : DataContractBase
    {
        public AbilityDataContract() { }

        public void SetAbilityDataContract(AbilityDataContract abilityData)
        {
            this.Created = abilityData.Created;
            this.Description = abilityData.Description;
            this.Modified = abilityData.Modified;
            this.Name = abilityData.Name;
            this.ResourceUri = abilityData.ResourceUri;
        }

        [DataMember(Name = "created")]
        public string Created;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "modified")]
        public string Modified;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
