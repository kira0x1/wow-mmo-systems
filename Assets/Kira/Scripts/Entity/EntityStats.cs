using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kira
{
    [CreateAssetMenu(fileName = "New Stats", menuName = "Character/Stats")]
    public class EntityStats : SerializedScriptableObject
    {
        public Dictionary<ResourceType, EntityResource> stats = new();

        public EntityResource GetStat(ResourceType resourceType)
        {
            return stats[resourceType];
        }
    }
}