using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class EggGroupDataContract
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
}
