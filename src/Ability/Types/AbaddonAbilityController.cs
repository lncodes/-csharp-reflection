using System;

namespace Lncodes.Example.Reflection;

public sealed class AbaddonAbilityController : AbilityController
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AbaddonAbilityController"/> class with predefined ability parameters.
    /// </summary>
    public AbaddonAbilityController() : base(damage: 10, cooldown: 130, range: 25) { }

    /// <summary>
    /// Activates the Mist Coil ability.
    /// </summary>
    public void CastMistCoilAbility() =>
        Console.WriteLine("'Mist Coil' ability has been activated.");

    /// <summary>
    /// Activates the Aphotic Shield ability.
    /// </summary>
    public void CastAphoticShieldAbility() =>
        Console.WriteLine("'Aphotic Shield' ability has been activated.");

    /// <summary>
    /// Activates the Curse Of Avernus ability.
    /// </summary>
    public void CastCurseOfAvernusAbility() =>
        Console.WriteLine("3. 'Curse Of Avernus' ability has been activated.");
}