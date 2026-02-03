using UnityEngine;
using UnityEngine.UI;

public class ButtonsHandler : MonoBehaviour
{
    [SerializeField] private Button _damageButton;
    [SerializeField] private Button _healButton;
    [SerializeField] private Health _health;

    private int _exampleDamage = 15;
    private int _exampleHeal = 10;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(OnDamageClick);
        _healButton.onClick.AddListener(OnHealClick);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(OnDamageClick);
        _healButton.onClick.RemoveListener(OnHealClick);
    }

    private void OnDamageClick()
    {
        _health.TakeDamage(_exampleDamage);
    }

    private void OnHealClick()
    {
        _health.Heal(_exampleHeal);
    }
}
