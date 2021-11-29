using System;
using UnityEngine;

namespace Kira
{
    [Serializable]
    public class SpellCost
    {
        [SerializeField] private ResourceType resourceType;
        [SerializeField] private float costPercentage;
        [SerializeField] private int cost;

        public ResourceType ResourceType => resourceType;
        public float CostPercentage => costPercentage;
        public int Cost => cost;
    }
}