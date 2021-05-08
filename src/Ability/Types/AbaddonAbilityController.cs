using System;

namespace Lncodes.Example.Reflection
{
    public sealed class AbaddonAbilityController : AbilityController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AbaddonAbilityController() : base(damage: 10, cooldown: 130, range: 25) { }

        /// <summary>
        /// Method for cast Mist Coil ability
        /// </summary>
        public void CastMistCoilAbility() =>
            Console.WriteLine("Mist Coil ability is used.");

        /// <summary>
        /// Method for cast Aphotic Shield ability
        /// </summary>
        public void CastAphoticShieldAbility() =>
            Console.WriteLine("Aphotic Shield ability is used.");

        /// <summary>
        /// Method for cast Curse Of Avernus ability
        /// </summary>
        public void CastCurseOfAvernusAbility() =>
            Console.WriteLine("Curse Of Avernus ability is used.");
    }
}