public class DamageDealer : ButtonClickEvent
{
    protected override void Execute()
    {
        Health.TakeDamage(Value);
    }
}