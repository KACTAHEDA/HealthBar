using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class HealthUIBase : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected virtual void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;        
    }

    protected virtual void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged();

    protected float GetHealthPercent()
    {
            return (float)_health.CurentHealth / _health.MaxHealth;
    }
}
