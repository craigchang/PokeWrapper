using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContacts
{
    [DataContract]
    public class PokemonDataContract
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "abilities")]
        public List<AbilityDataContract> Abilities;
    }
}
