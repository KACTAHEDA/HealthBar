using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;


    private void Start()
    {
        DisplayHealth();
    }

    private void OnEnable()
    {
        _health.HealthChanged += DisplayHealth;        
    }

    private void OnDisable()
    {
        _health.HealthChanged -= DisplayHealth;
    }

    private void DisplayHealth()
    {
        if (_health == null)
            return;

        _healthText.text = $"{_health.CurentHealth} / {_health.MaxHealth}";
        _slider.value = (float)_health.CurentHealth / _health.MaxHealth;
    }
}
