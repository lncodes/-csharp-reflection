using System;

namespace Lncodes.Example.Reflection
{
    public sealed class FlameLordAbilityController : AbilityController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FlameLordAbilityController() : base(damage: 50, cooldown: 150, range: 5) { }

        /// <summary>
        /// Method for cast Meteor ability
        /// </summary>
        public void CastMeteorAbility() =>
            Console.WriteLine("Meteor ability is used.");

        /// <summary>
        /// Method for cast Flame Shot ability
        /// </summary>
        public void CastFlameShotAbility() =>
            Console.WriteLine("Flame Shot ability is used.");

        /// <summary>
        /// Method for cast Fire Storm ability
        /// </summary>
        public void CastFireStormAbility() =>
            Console.WriteLine("Fire Storm ability is used.");
    }
}