using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Text _healthText;

    public void UpdateHealth(float health)
    {
        _healthBar.value = health;
        _healthText.text = $"HP: {health}";
    }
}
