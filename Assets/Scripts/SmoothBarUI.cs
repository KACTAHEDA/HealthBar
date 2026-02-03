using UnityEngine.UI;
using UnityEngine;

public class SmoothBarUI : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 0.1f;

    private float _targetValue;

    private void Start()
    {
        UpdateTargetValue();
        _slider.value = _targetValue;
    }

    private void OnEnable()
    {
        _health.HealthChanged += UpdateTargetValue;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateTargetValue;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed * Time.deltaTime);
    }

    private void UpdateTargetValue()
    {
        _targetValue = GetHealthPercent();
    }

    private float GetHealthPercent()
    {
        return (float)_health.CurentHealth / _health.MaxHealth;
    }
}
