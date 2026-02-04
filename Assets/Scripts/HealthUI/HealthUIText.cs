using TMPro;
using UnityEngine;

public class HealthUIText : HealthUIBase
{
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Start()
    {
        DisplayText();
    }

    private void DisplayText()
    {
        _healthText.text = $"{_health.CurentHealth} / {_health.MaxHealth}";
    }

    protected override void OnHealthChanged()
    {
        DisplayText();
    }
}
