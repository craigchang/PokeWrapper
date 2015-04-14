using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class GameDataContract
    {
        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "generation")]
        public int Generation { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "release_year")]
        public int ReleaseYear { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }

    }
}
