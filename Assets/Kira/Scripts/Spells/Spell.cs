using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kira
{
    [CreateAssetMenu(fileName = "New Spell Data", menuName = "Spells/Spell Data")]
    public class Spell : SerializedScriptableObject
    {
        [SerializeField] private float coolDownTime = 0.1f;
        [SerializeField] private float globalCoolDownTime;
        [SerializeField] private float castTime;
        [SerializeField] private float maxRange = 10;
        [SerializeField] private float speed;
        [SerializeField] private Dictionary<ResourceType, SpellCost> spellCosts;

        public IEnumerable<SpellCost> SpellCosts => spellCosts.Values;
        public SpellCost GetCost(ResourceType resourceType) => spellCosts[resourceType];
        public float CastTime => castTime;
        public float CoolDownTime => coolDownTime;
        public float MaxRange => maxRange;
    }
}