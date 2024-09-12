using System;

namespace Lncodes.Example.Reflection;

public sealed class BaneAbilityController : AbilityController
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaneAbilityController"/> class with predefined ability parameters.
    /// </summary>
    public BaneAbilityController() : base(damage: 100, cooldown: 200, range: 10) { }

    /// <summary>
    /// Activates the Enfeeble ability.
    /// </summary>
    public void CastEnfeebleAbility() =>
        Console.WriteLine("'Enfeeble' ability has been activated.");

    /// <summary>
    /// Activates the Nightmare ability.
    /// </summary>
    public void CastNightmareAbility() =>
        Console.WriteLine("'Nightmare' ability has been activated.");

    /// <summary>
    /// Activates the Brain Sap ability.
    /// </summary>
    public void CastBrainSapAbility() =>
        Console.WriteLine("'Brain Sap' ability has been activated.");
}