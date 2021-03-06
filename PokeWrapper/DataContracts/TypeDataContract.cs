﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PokeWrapper.DataContracts
{
    [DataContract]
    public class TypeDataContract : DataContractBase
    {
        public TypeDataContract() { }

        public void SetTypeDataContract(TypeDataContract typeData)
        {
            this.Created = typeData.Created;
            this.Id = typeData.Id;
            this.Ineffective = typeData.Ineffective;
            this.Modified = typeData.Modified;
            this.Name = typeData.Name;
            this.NoEffect = typeData.NoEffect;
            this.Resistance = typeData.Resistance;
            this.TypeResourceUri = typeData.TypeResourceUri;
            this.SuperEffective = typeData.SuperEffective;
            this.Weakness = typeData.Weakness;
        }

        public List<TypeDataContract> httpGetIneffectiveTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in Ineffective)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        public List<TypeDataContract> httpGetNoEffectTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in NoEffect)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        public List<TypeDataContract> httpGetResistanceTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in Resistance)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        public TypeDataContract httpGetSprite()
        {
            TypeDataContract type = new TypeDataContract();
            string jsonStr = base.HttpGet(TypeResourceUri);
            type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);

            Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);

            return type;
        } 

        public List<TypeDataContract> httpGetSuperEffectiveTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in SuperEffective)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        public List<TypeDataContract> httpGetWeaknessTypes()
        {
            List<TypeDataContract> types = new List<TypeDataContract>();
            foreach (var resourceUri in Weakness)
            {
                string jsonStr = base.HttpGet(resourceUri.ResourceUri);
                var type = JsonConvert.DeserializeObject<TypeDataContract>(jsonStr);
                types.Add(type);

                Debug.WriteLine("Type Id: " + type.Id + ", Type Name: " + type.Name);
            }
            return types;
        }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "ineffective")]
        public List<ResourceUriDataContract> Ineffective { get; set; }

        [DataMember(Name = "modified")]
        public DateTime? Modified { get; set; }

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "no_effect")]
        public List<ResourceUriDataContract> NoEffect { get; set; }

        [DataMember(Name = "resistance")]
        public List<ResourceUriDataContract> Resistance { get; set; }

        [DataMember(Name = "resource_uri")]
        public string TypeResourceUri;

        [DataMember(Name = "super_effective")]
        public List<ResourceUriDataContract> SuperEffective { get; set; }

        [DataMember(Name = "weakness")]
        public List<ResourceUriDataContract> Weakness { get; set; }
    }
}
