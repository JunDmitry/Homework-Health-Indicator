using UnityEngine;

public abstract class HealthIndicator : MonoBehaviour
{
    [SerializeField] private GameObject _healthHandler;

    private IHealthChangeHandler _healthChangeHandler;

    private void Awake()
    {
        _healthChangeHandler = _healthHandler.GetComponent<IHealthChangeHandler>();
    }

    private void OnValidate()
    {
        if (_healthHandler != null && _healthHandler.TryGetComponent<IHealthChangeHandler>(out _) == false)
        {
            Debug.LogWarning($"{_healthHandler.name} don't contains Component that implement interface {nameof(IHealthChangeHandler)}!");
            _healthHandler = null;
        }
    }

    protected float CurrentHealth => _healthChangeHandler.Current;
    protected float MaxHealth => _healthChangeHandler.Max;

    protected virtual void OnEnable()
    {
        _healthChangeHandler.CurrentHealthChanged += OnCurrentHealthChanged;
        _healthChangeHandler.MaxHealthChanged += OnMaxHealthChanged;
    }

    protected virtual void OnDisable()
    {
        _healthChangeHandler.CurrentHealthChanged -= OnCurrentHealthChanged;
        _healthChangeHandler.MaxHealthChanged -= OnMaxHealthChanged;
    }

    protected abstract void OnCurrentHealthChanged(float value);

    protected abstract void OnMaxHealthChanged(float value);
}