using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContacts
{
    [DataContract]
    public class PokemonDataContract
    {
        public PokemonDataContract(){}

        [DataMember(Name = "abilities")]
        public List<AbilityDataContract> Abilities;

        [DataMember(Name = "attack")]
        public int Attack { get; set; }

        [DataMember(Name = "catch_rate")]
        public int CatchRate { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "defense")]
        public int Defense { get; set; }

        [DataMember(Name = "descriptions")]
        public List<DescriptionDataContract> Descriptions { get; set; }

        [DataMember(Name = "egg_cycles")]
        public int EggCycles { get; set; }

        [DataMember(Name = "egg_groups")]
        public List<EggGroupDataContract> EggGroups { get; set; }

        [DataMember(Name = "ev_yield")]
        public string EvYield { get; set; }

        [DataMember(Name = "evolutions")]
        public List<EvolutionDataContract> Evolutions { get; set; }

        [DataMember(Name = "exp")]
        public int Exp { get; set; }

        [DataMember(Name = "growth_rate")]
        public string GrowthRate { get; set; }

        [DataMember(Name = "happiness")]
        public int Happiness { get; set; }

        [DataMember(Name = "height")]
        public string Height { get; set; }

        [DataMember(Name = "hp")]
        public int Hp { get; set; }

        [DataMember(Name = "male_female_ratio")]
        public string MaleFemaleRatio { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "moves")]
        public List<MoveDataContract> Moves { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "national_id")]
        public int NationalId { get; set; }

        [DataMember(Name = "pkdx_id")]
        public int PkdxId { get; set; }

        [DataMember(Name = "resource_uri")]
        public string ResourceUri { get; set; }

        [DataMember(Name = "sp_atk")]
        public int SpAtk { get; set; }

        [DataMember(Name = "sp_def")]
        public int SpDef { get; set; }

        [DataMember(Name = "species")]
        public string Species { get; set; }

        [DataMember(Name = "speed")]
        public int Speed { get; set; }

        [DataMember(Name = "sprites")]
        public List<SpriteDataContract> Sprites { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "types")]
        public List<TypeDataContract> Types { get; set; }

        [DataMember(Name = "weight")]
        public string Weight { get; set; }
    }
}
