public class HealthHealer : ButtonClickEvent
{
    protected override void Execute()
    {
        Health.Replenish(Value);
    }
}