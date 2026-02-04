using UnityEngine;

public class HealButton : HealthButton
{
    [SerializeField] private int _heal = 10;
    protected override void OnButtonClick()
    {
        _health.Heal(_heal);
    }
}
