using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class DescriptionDataContract
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }
    }
}
