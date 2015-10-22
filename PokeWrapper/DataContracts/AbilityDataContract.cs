using Newtonsoft.Json;
using PokeWrapper.DataContracts;
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
    public class AbilityDataContract : DataContractBase
    {
        public AbilityDataContract() { }

        public void SetAbilityDataContract(AbilityDataContract abilityData)
        {
            this.Created = abilityData.Created;
            this.Description = abilityData.Description;
            this.Id = abilityData.Id;
            this.Modified = abilityData.Modified;
            this.Name = abilityData.Name;
            this.AbilityResourceUri = abilityData.AbilityResourceUri;
        }

        public AbilityDataContract httpGetAbility()
        {
            AbilityDataContract ability = new AbilityDataContract();
            string jsonStr = base.HttpGet(AbilityResourceUri);
            ability = JsonConvert.DeserializeObject<AbilityDataContract>(jsonStr);

            Debug.WriteLine("Ability Id: " + ability.Id + ", Ability Name: " + ability.Name);

            return ability;
        }

        [DataMember(Name = "created")]
        public DateTime? Created;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "modified")]
        public DateTime? Modified;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "resource_uri")]
        public string AbilityResourceUri;
    }
}
