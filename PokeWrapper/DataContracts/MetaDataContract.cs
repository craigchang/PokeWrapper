using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class MetaDataContract
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        [DataMember(Name = "next")]
        public object Next { get; set; }

        [DataMember(Name = "offset")]
        public int Offset { get; set; }

        [DataMember(Name = "previous")]
        public object Previous { get; set; }

        [DataMember(Name = "total_count")]
        public int TotalCount { get; set; }
    }
}
