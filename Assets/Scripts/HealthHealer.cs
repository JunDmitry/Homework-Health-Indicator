using UnityEngine;

public class HealthHealer : ButtonClickEvent
{
    [SerializeField] private float _healStrength;

    protected override void Execute()
    {
        Health.Replenish(_healStrength);
    }

    protected override void ChangeValue(string rawDamage)
    {
        _healStrength = float.Parse(rawDamage);
    }
}