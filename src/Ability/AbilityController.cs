namespace Lncodes.Example.Reflection;

public abstract class AbilityController
{
    protected readonly uint Damage;
    protected readonly float Cooldown;

    [Ignore]
    protected readonly float Range;

    /// <summary>
    /// Initializes a new instance of the <see cref="AbilityController"/> class.
    /// </summary>
    /// <param name="damage">The damage value of the ability.</param>
    /// <param name="cooldown">The cooldown duration of the ability.</param>
    /// <param name="range">The range of the ability.</param>
    protected AbilityController(uint damage, float cooldown, float range) =>
        (Damage, Cooldown, Range) = (damage, cooldown, range);
}