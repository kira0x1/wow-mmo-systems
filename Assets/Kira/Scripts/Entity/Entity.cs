using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kira
{
    [Serializable, CreateAssetMenu(fileName = "New Entity", menuName = "Character/Entity")]
    public class Entity : SerializedScriptableObject
    {
        [SerializeField]
        private string unitName;

        [SerializeField]
        private Dictionary<ResourceType, EntityResource> resources = new();

        public string Name => unitName;

        public EntityResource GetResource(ResourceType resourceType) => resources[resourceType];
    }
}