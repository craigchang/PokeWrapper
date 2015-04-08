using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContacts
{
    [DataContract]
    public class AbilityDataContract
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
