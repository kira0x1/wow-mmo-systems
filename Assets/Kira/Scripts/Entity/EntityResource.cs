using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Kira
{
    [Serializable]
    public class EntityResource
    {
        [SerializeField]
        private ResourceType resourceType;

        [SerializeField]
        private int currentValue;
        private int maxAmount;

        [SerializeField]
        private int baseAmount;

        [SerializeField]
        private List<ResourceModifier> resourceMods = new();

        public delegate void OnValueChangedEvent();
        public OnValueChangedEvent OnValueChanged;
        public ResourceType ResourceType => resourceType;


        public EntityResource()
        {
            maxAmount = Max();
        }

        public int CurrentValue => currentValue;

        public int Max()
        {
            maxAmount = baseAmount;

            foreach (ResourceModifier mod in resourceMods.Where(mod => mod.IsFlat))
            {
                maxAmount += mod.FlatModifier;
            }

            float percentage = resourceMods.Where(mod => !mod.IsFlat).Sum(mod => mod.Multiplier);
            float percentageBuff = maxAmount * percentage;
            maxAmount += Mathf.CeilToInt(percentageBuff);

            return maxAmount;
        }


        public void SetValue(int value)
        {
            currentValue = value;
            OnValueChanged?.Invoke();
        }

        public void Add(int value)
        {
            currentValue += value;
            currentValue = Mathf.Clamp(currentValue, 0, maxAmount);
            OnValueChanged?.Invoke();
        }

        public void Subtract(int value)
        {
            currentValue -= value;
            currentValue = Mathf.Clamp(currentValue, 0, maxAmount);
            OnValueChanged?.Invoke();
        }
    }
}