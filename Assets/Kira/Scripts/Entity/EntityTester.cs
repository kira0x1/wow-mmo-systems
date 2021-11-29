using UnityEngine;

namespace Kira
{
    public class EntityTester : MonoBehaviour
    {
        [SerializeField]
        private int damageAmount = 10;

        [SerializeField]
        private int healAmount = 50;

        [SerializeField] private KeyCode damageKey = KeyCode.F;
        [SerializeField] private KeyCode healKey = KeyCode.V;

        private EntityManager entityManager;

        private void Awake()
        {
            entityManager = GetComponent<EntityManager>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(damageKey)) entityManager.Damage(damageAmount);
            if (Input.GetKeyDown(healKey)) entityManager.Heal(healAmount);
        }
    }
}