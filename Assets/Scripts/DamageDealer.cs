using UnityEngine;

public class DamageDealer : ButtonClickEvent
{
    [SerializeField] private float _damage;

    protected override void Execute()
    {
        Health.TakeDamage(_damage);
    }

    protected override void ChangeValue(string rawDamage)
    {
        _damage = float.Parse(rawDamage);
    }
}