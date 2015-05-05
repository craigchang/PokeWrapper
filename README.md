# PokeWrapper

A C# .NET Application wrapper for the REST APIs provided in [pokeapi.co] (http://pokeapi.co/).

### Requirements

1. C# 5.0 and .NET 4.5 Framework (up-to-date)
2. [Json.NET] (http://www.newtonsoft.com/json) library (It's too good to pass up. I prefer using this library to deserialize json strings into C# objects as opposed to the standard DataContract Serialization library.)
3. Visual Studios (or other IDE) to build and compile C# .NET applications.

### Documentation

The data contracts under _/PokeWrapper/DataContracts/_ are created to mimic json-like documents.

For example, the ability API (http://pokeapi.co/api/v1/ability/1) produces the following json structure:

```json
{
  "created": "2013-11-03T15:05:59.481261",
  "description": "",
  "id": 1,
  "modified": "2013-11-03T15:05:59.481206",
  "name": "Stench",
  "resource_uri": "/api/v1/ability/1/"
}
```

This json structure will be modeled in the following way in a C# object:

```C#
  [DataContract]
    public class AbilityDataContract : DataContractBase
    {
        public AbilityDataContract() { }

        [DataMember(Name = "created")]
        public DateTime? Created;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "modified")]
        public DateTime? Modified;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "resource_uri")]
        public string ResourceUri;
    }
```

Each data contract object extends a base model (DataContractBase) that provides an HTTP GET method, which returns the response as a JSON string. The subclass that inherits the base model is responsible for deserializing the JSON string into the appropriate subclass object.

The DataContractGenerator class generates data contract objects based on the common base class DataContractBase. The getInstance() method will return any data contract object based on specific paramters. For example, in "http://pokeapi.co/api/v1/ability/1",  the id would be 1 and you would need to specify the correct enumerated value "Ability" in the DataContractEnum. Since the subclass of the returned data contract object is unknown, you would need to assign the correct subclass object.

```C#

AbilityDataContract ability = (AbilityDataContract) DataContractGenerator.getInstance(DataContractType.Ability, 1);

```

### Work Still in Progress

1. Caching/Database/Flatfile storage to reduce number of HTTP GET Requests to the pokeapi.co server (for more information see the [API documentation] (http://pokeapi.co/docs/)).
2. Exception Handling to cover all possible user cases.
3. Provide more documentation on the Wrapper API.

### Latest Comments

v.0.0.1 (4/15/2015) - Completed DataContract objects and created a DataContract Generator. Currently in the process of learning C# and .NET environment.
