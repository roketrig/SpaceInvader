using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Renderer healthBarRenderer;
    [SerializeField] private TextMeshProUGUI healthText; 
    private Material healthBarMaterial;

    private void Awake()
    {
        if (healthBarRenderer != null)
        {
            healthBarMaterial = healthBarRenderer.material;
        }
    }

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        if (healthBarMaterial != null)
        {
            float healthNormalized = currentValue / maxValue;
            healthBarMaterial.SetFloat("_Health", healthNormalized);
        }

        if (healthText != null)
        {
            healthText.text = $"{Mathf.Ceil(currentValue)} / {Mathf.Ceil(maxValue)}";
        }
    }
}