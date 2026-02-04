using UnityEngine;
using UnityEngine.UI;

public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] protected Button _button;
    [SerializeField] protected Health _health;

    protected virtual void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    protected virtual void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();    
}
