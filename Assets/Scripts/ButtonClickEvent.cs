using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonClickEvent : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected Button Button;
    [SerializeField] protected TMP_InputField InputField;

    private void OnEnable()
    {
        Button.onClick.AddListener(Execute);
        InputField.onValueChanged.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(Execute);
        InputField.onValueChanged.RemoveListener(ChangeValue);
    }

    protected abstract void Execute();

    protected abstract void ChangeValue(string rawDamage);
}