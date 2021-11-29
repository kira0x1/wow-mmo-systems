using System.Collections.Generic;
using UnityEngine;

namespace Kira
{
    public class SpellManager : MonoBehaviour
    {
        [SerializeField]
        private List<Spell> spells = new List<Spell>();

        private EntityManager entityManager;

        private void Awake()
        {
            entityManager = GetComponent<EntityManager>();
        }

        public bool CastSpell(Spell spell)
        {
            if (!HasCost(spell)) return false;

            foreach (SpellCost cost in spell.SpellCosts)
            {
                var resource = entityManager.GetResource(cost.ResourceType);
                resource.Subtract(cost.Cost);
            }

            return true;
        }

        public bool HasCost(Spell spell)
        {
            foreach (SpellCost cost in spell.SpellCosts)
            {
                var resource = entityManager.GetResource(cost.ResourceType);
                if (resource.CurrentValue < cost.Cost) return false;
            }

            return true;
        }
    }
}