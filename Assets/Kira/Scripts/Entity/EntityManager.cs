using UnityEngine;

namespace Kira
{
    [RequireComponent(typeof(PlayerUI))]
    public class EntityManager : MonoBehaviour
    {
        [SerializeField]
        private Entity entity;
        public Entity Entity => entity;

        public EntityResource GetResource(ResourceType resourceType) => entity.GetResource(resourceType);

        public void Damage(int amount)
        {
            entity.GetResource(ResourceType.Health).Subtract(amount);
        }

        public void Heal(int amount)
        {
            entity.GetResource(ResourceType.Health).Add(amount);
        }
    }
}