using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Kira
{
    public class ResourceBar : MonoBehaviour
    {
        [SerializeField] private Image _fill;
        [SerializeField] private TextMeshProUGUI _text;

        private int curAmount;
        private int maxAmount;
        private EntityResource resource;

        public void SetResource(EntityResource resource)
        {
            this.resource = resource;
            UpdateResource();
            this.resource.OnValueChanged += UpdateResource;
        }


        public void UpdateResource()
        {
            curAmount = resource.CurrentValue;
            maxAmount = resource.Max();
            UpdateUI();
        }

        private void UpdateUI()
        {
            float perc = CalculatePercentage();
            _fill.fillAmount = perc;
            UpdateText(curAmount, maxAmount);
        }

        private void UpdateText(int cur, int max)
        {
            _text.text = $"{cur} / {max}";
        }

        private float CalculatePercentage()
        {
            float perc = (curAmount + 0.0f) / maxAmount;
            return perc;
        }
    }
}