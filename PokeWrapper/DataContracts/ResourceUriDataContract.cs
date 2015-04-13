using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class ResourceUriDataContract
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;

        // For MoveDataContract
        [DataMember(Name = "learn_type")]
        public string LearnType { get; set; }

        // For MoveDataContract
        [DataMember(Name = "level")]
        public int? Level { get; set; }
    }
}
