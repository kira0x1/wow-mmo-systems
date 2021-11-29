using System;

namespace Kira
{
    [Serializable]
    public struct ResourceModifier
    {
        public int FlatModifier { get; private set; }
        public ResourceType ResourceType { get; private set; }

        public float Multiplier { get; private set; }

        public bool IsFlat { get; private set; }

        public ResourceModifier(ResourceType resourceType, int flatMod, float percMod = 0, bool isFlat = true)
        {
            ResourceType = resourceType;
            FlatModifier = flatMod;
            Multiplier = percMod;
            IsFlat = isFlat;
        }
    }
}