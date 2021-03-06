﻿using Newtonsoft.Json;
using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class PokemonDataContract : DataContractBase
    {
        public PokemonDataContract() { }

        public void SetPokemonDataContract(PokemonDataContract pokemon) {
            this.AbilityResourceUriList = pokemon.AbilityResourceUriList;
            this.Attack = pokemon.Attack;
            this.CatchRate = pokemon.CatchRate;
            this.Created = pokemon.Created;
            this.Defense = pokemon.Defense;
            this.DescriptionResourceUriList = pokemon.DescriptionResourceUriList;
            this.EggCycles = pokemon.EggCycles;
            this.EggGroupResourceUriList = pokemon.EggGroupResourceUriList;
            this.EvolutionList = pokemon.EvolutionList;
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
            this.PokemonResourceUri = pokemon.PokemonResourceUri;
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
                var ability = JsonConvert.DeserializeObject<AbilityDataContract>(jsonStr);
                abilities.Add(ability);

                Debug.WriteLine("Ability Id: " + ability.Id + ", Pokemon Name: " + ability.Name);
            }
            return abilities;
        }

        public List<DescriptionDataContract> httpGetPokemonDescriptions()
        {
            List<DescriptionDataContract> descriptions = new List<DescriptionDataContract>();
            foreach (var resourceUri in DescriptionResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var description = JsonConvert.DeserializeObject<DescriptionDataContract>(jsonStr);
                descriptions.Add(description);

                Debug.WriteLine("Description Id: " + description.Id + ", Description Name: " + description.Name);
            }
            return descriptions;
        }

        public List<EggGroupDataContract> httpGetPokemonEggGroups()
        {
            List<EggGroupDataContract> eggGroups = new List<EggGroupDataContract>();
            foreach (var resourceUri in EggGroupResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var eggGroup = JsonConvert.DeserializeObject<EggGroupDataContract>(jsonStr);
                eggGroups.Add(eggGroup);

                Debug.WriteLine("Egg Group Id: " + eggGroup.Id + ", Egg Group Name: " + eggGroup.Name);
            }
            return eggGroups;
        }

        public List<MoveDataContract> httpGetPokemonMoves()
        {
            List<MoveDataContract> moves = new List<MoveDataContract>();
            foreach (var resourceUri in MoveResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var move = JsonConvert.DeserializeObject<MoveDataContract>(jsonStr);
                move.Level = resourceUri.Level;
                move.LearnType = resourceUri.LearnType;
                moves.Add(move);

                Debug.WriteLine("Move Id: " + move.Id + ", Move Name: " + move.Name);
            }
            return moves;
        }

        public PokemonDataContract httpGetPokemon()
        {
            PokemonDataContract pokemon = new PokemonDataContract();
            string jsonStr = base.HttpGet(PokemonResourceUri);
            pokemon = JsonConvert.DeserializeObject<PokemonDataContract>(jsonStr);

            Debug.WriteLine("Pokemon Id: " + pokemon.PkdxId + ", Pokemon Name: " + pokemon.Name);

            return pokemon;
        }

        public List<SpriteDataContract> httpGetPokemonSprites()
        {
            List<SpriteDataContract> sprites = new List<SpriteDataContract>();
            foreach (var resourceUri in SpriteResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var sprite = JsonConvert.DeserializeObject<SpriteDataContract>(jsonStr);
                sprites.Add(sprite);

                Debug.WriteLine("Sprite Id: " + sprite.Id + ", Sprite Name: " + sprite.Name);
            }
            return sprites;
        }

        public List<TypeDataContract> httpGetPokemonTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in TypeResourceUriList)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        [DataMember(Name = "abilities")]
        public List<ResourceUriDataContract> AbilityResourceUriList { get; set; }

        [DataMember(Name = "attack")]
        public int Attack { get; set; }

        [DataMember(Name = "catch_rate")]
        public int CatchRate { get; set; }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

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
        public List<EvolutionDataContract> EvolutionList { get; set; }

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
        public DateTime? Modified { get; set; }

        [DataMember(Name = "moves")]
        public List<ResourceUriDataContract> MoveResourceUriList { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "national_id")]
        public int NationalId { get; set; }

        [DataMember(Name = "pkdx_id")]
        public int PkdxId { get; set; }

        [DataMember(Name = "resource_uri")]
        public string PokemonResourceUri { get; set; }

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
