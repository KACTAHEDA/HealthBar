using UnityEngine.UI;
using UnityEngine;

public class HealthBarUI : HealthUIBase
{
    [SerializeField] protected Slider _slider;

    protected override void OnHealthChanged()
    {
        _slider.value = GetHealthPercent();
    }
}
