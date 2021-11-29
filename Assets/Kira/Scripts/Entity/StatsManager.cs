using UnityEngine;

namespace Kira
{
    public class StatsManager : MonoBehaviour
    {
        public EntityStats stats;

        public EntityResource Health =>
            GetStat(ResourceType.Health);

        public EntityResource MaxHealth
            => GetStat(ResourceType.MaxHealth);

        public EntityResource Mana =>
            GetStat(ResourceType.Mana);

        public EntityResource MaxMana =>
            GetStat(ResourceType.MaxMana);

        public EntityResource GetStat(ResourceType resourceType)
        {
            return stats.GetStat(resourceType);
        }
    }
}