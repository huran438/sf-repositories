using System;
using Newtonsoft.Json;
using UnityEngine;

namespace SFramework.Repositories.Runtime
{
    [Serializable]
    public abstract class SFNode : ISFNode
    {
        [SerializeField, JsonIgnore]
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public abstract ISFNode[] Nodes { get; }
    }
}