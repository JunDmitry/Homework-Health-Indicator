using System;

public interface IHealthChangeHandler
{
    event Action<float> CurrentHealthChanged;

    event Action<float> MaxHealthChanged;

    float Current { get; }
    float Max { get; }
}