using System;

namespace Lncodes.Example.Reflection;

public sealed class FlameLordAbilityController : AbilityController
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlameLordAbilityController"/> class with predefined ability parameters.
    /// </summary>
    public FlameLordAbilityController() : base(damage: 50, cooldown: 150, range: 5) { }

    /// <summary>
    /// Activates the Meteor ability.
    /// </summary>
    public void CastMeteorAbility() =>
        Console.WriteLine("'Meteor' ability has been activated.");

    /// <summary>
    /// Activates the Flame Shot ability.
    /// </summary>
    public void CastFlameShotAbility() =>
        Console.WriteLine("'Flame Shot' ability has been activated.");

    /// <summary>
    /// Activates the Fire Storm ability.
    /// </summary>
    public void CastFireStormAbility() =>
        Console.WriteLine("'Fire Storm' ability has been activated.");
}