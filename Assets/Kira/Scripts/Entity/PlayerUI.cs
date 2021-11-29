using TMPro;
using UnityEngine;

namespace Kira
{
    [RequireComponent(typeof(EntityManager))]
    public class PlayerUI : MonoBehaviour
    {
        private EntityManager entityManager;

        [SerializeField] private TextMeshProUGUI unitNameText;

        [SerializeField]
        private ResourceBar healthBar;

        [SerializeField]
        private ResourceBar powerBar;

        private void Awake()
        {
            entityManager = GetComponent<EntityManager>();
            healthBar.SetResource(entityManager.GetResource(ResourceType.Health));
            powerBar.SetResource(entityManager.GetResource(ResourceType.Mana));
        }
    }
}