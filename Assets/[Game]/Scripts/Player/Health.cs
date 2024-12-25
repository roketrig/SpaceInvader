
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    [SerializeField] private Image healthFillImage; 
    [SerializeField] private TextMeshProUGUI healthText; 

    private void Start()
    {
        UpdateHealthBar(500f,1000f);
    }

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        if (healthFillImage != null)
        {
            healthFillImage.fillAmount = currentValue / maxValue;
        }

        if (healthText != null)
        {
            healthText.text = $"{Mathf.Ceil(currentValue)} / {Mathf.Ceil(maxValue)}";
        }
    }
    
}

