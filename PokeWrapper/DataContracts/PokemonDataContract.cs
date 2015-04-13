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
    public class PokemonDataContract : DataContractBase
    {
        public PokemonDataContract() { }

        public PokemonDataContract(PokemonDataContract pokemon)
        {
            this.AbilityResourceUriList = new List<ResourceUriDataContract>();
            this.DescriptionResourceUriList = new List<ResourceUriDataContract>();
            this.EggGroupResourceUriList = new List<ResourceUriDataContract>();
            this.EvolutionResourceUriList = new List<ResourceUriDataContract>();
            this.MoveResourceUriList = new List<ResourceUriDataContract>();
            this.SpriteResourceUriList = new List<ResourceUriDataContract>();
            this.TypeResourceUriList = new List<ResourceUriDataContract>();

            try
            {
                string jsonStr = base.HttpGet(pokemon.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(PokemonDataContract));

                PokemonDataContract pokedexData = (PokemonDataContract)jsonSerializer.ReadObject(jsonStream);
                SetPokemonDataContract(pokedexData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { }
        }

        public void SetPokemonDataContract(PokemonDataContract pokemon) {
            this.AbilityResourceUriList = pokemon.AbilityResourceUriList;
            this.Attack = pokemon.Attack;
            this.CatchRate = pokemon.CatchRate;
            this.Created = pokemon.Created;
            this.Defense = pokemon.Defense;
            this.DescriptionResourceUriList = pokemon.DescriptionResourceUriList;
            this.EggCycles = pokemon.EggCycles;
            this.EggGroupResourceUriList = pokemon.EggGroupResourceUriList;
            this.EvolutionResourceUriList = pokemon.EvolutionResourceUriList;
            this.EvYield = pokemon.EvYield;
            this.Exp = pokemon.Exp;
            this.GrowthRate = pokemon.GrowthRate;
            this.Happiness = pokemon.Happiness;
            this.Height = pokemon.Height;
            this.Hp = pokemon.Hp;
            this.MaleFemaleRatio = pokemon.MaleFemaleRatio;
            this.Modified = pokemon.Modified;
            this.MoveResourceUriList = pokemon.MoveResourceUriList;
            this.Name = pokemon.Name;
            this.NationalId = pokemon.NationalId;
            this.PkdxId = pokemon.PkdxId;
            this.ResourceUri = pokemon.ResourceUri;
            this.SpAtk = pokemon.SpAtk;
            this.SpDef = pokemon.SpDef;
            this.Speed = pokemon.Speed;
            this.SpriteResourceUriList = pokemon.SpriteResourceUriList;
            this.Total = pokemon.Total;
            this.TypeResourceUriList = pokemon.TypeResourceUriList;
            this.Weight = pokemon.Weight;
        }

        public List<AbilityDataContract> httpGetPokemonAbilities()
        {
            List<AbilityDataContract> abilities = new List<AbilityDataContract>();
            foreach (var resourceUri in AbilityResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(AbilityDataContract));

                var ability = (AbilityDataContract)jsonSerializer.ReadObject(jsonStream);
                abilities.Add(ability);
            }
            return abilities;
        }

        public List<DescriptionDataContract> httpGetPokemonDescriptions()
        {
            List<DescriptionDataContract> descriptions = new List<DescriptionDataContract>();
            foreach (var resourceUri in DescriptionResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DescriptionDataContract));

                var description = (DescriptionDataContract)jsonSerializer.ReadObject(jsonStream);
                descriptions.Add(description);
            }
            return descriptions;
        }

        public List<EggGroupDataContract> httpGetPokemonEggGroups()
        {
            List<EggGroupDataContract> eggGroups = new List<EggGroupDataContract>();
            foreach (var resourceUri in EggGroupResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(EggGroupDataContract));

                var eggGroup = (EggGroupDataContract)jsonSerializer.ReadObject(jsonStream);
                eggGroups.Add(eggGroup);
            }
            return eggGroups;
        }

        public List<EvolutionDataContract> httpGetPokemonEvolutions()
        {
            List<EvolutionDataContract> evolutions = new List<EvolutionDataContract>();
            foreach (var resourceUri in EvolutionResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(EvolutionDataContract));

                var evolution = (EvolutionDataContract)jsonSerializer.ReadObject(jsonStream);
                evolutions.Add(evolution);
            }
            return evolutions;
        }

        public List<MoveDataContract> httpGetPokemonMoves()
        {
            //Integer i = new Integer(2);
            //int j = i;
            List<MoveDataContract> moves = new List<MoveDataContract>();
            foreach (var resourceUri in MoveResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(MoveDataContract));

                var move = (MoveDataContract)jsonSerializer.ReadObject(jsonStream);
                move.Level = resourceUri.Level;
                move.LearnType = resourceUri.LearnType;
                moves.Add(move);
            }
            return moves;
        }

        public List<SpriteDataContract> httpGetPokemonSprites()
        {
            List<SpriteDataContract> abilities = new List<SpriteDataContract>();
            foreach (var resourceUri in SpriteResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(SpriteDataContract));

                var ability = (SpriteDataContract)jsonSerializer.ReadObject(jsonStream);
                abilities.Add(ability);
            }
            return abilities;
        }

        public List<TypeDataContract> httpGetPokemonTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in TypeResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                MemoryStream jsonStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonStr));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TypeDataContract));

                var type = (TypeDataContract)jsonSerializer.ReadObject(jsonStream);
                types.Add(type);
            }
            return types;
        }

        [DataMember(Name = "abilities")]
        public List<ResourceUriDataContract> AbilityResourceUriList;

        [DataMember(Name = "attack")]
        public int Attack { get; set; }

        [DataMember(Name = "catch_rate")]
        public int CatchRate { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "defense")]
        public int Defense { get; set; }

        [DataMember(Name = "descriptions")]
        public List<ResourceUriDataContract> DescriptionResourceUriList { get; set; }

        [DataMember(Name = "egg_cycles")]
        public int EggCycles { get; set; }

        [DataMember(Name = "egg_groups")]
        public List<ResourceUriDataContract> EggGroupResourceUriList { get; set; }

        [DataMember(Name = "ev_yield")]
        public string EvYield { get; set; }

        [DataMember(Name = "evolutions")]
        public List<ResourceUriDataContract> EvolutionResourceUriList { get; set; }

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
        public List<ResourceUriDataContract> MoveResourceUriList { get; set; }

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
        public List<ResourceUriDataContract> SpriteResourceUriList { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "types")]
        public List<ResourceUriDataContract> TypeResourceUriList { get; set; }

        [DataMember(Name = "weight")]
        public string Weight { get; set; }
    }
}
