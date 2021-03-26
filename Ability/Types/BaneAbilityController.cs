using System;

namespace Lncodes.Example.Reflection
{
    public sealed class BaneAbilityController : AbilityController
    {
        // Constructor
        public BaneAbilityController() : base(damage: 100, cooldown: 200, range: 10) { }

        /// <summary>
        /// Method for cast Enfeeble ability
        /// </summary>
        public void CastEnfeebleAbility() =>
            Console.WriteLine("Enfeeble ability is used.");

        /// <summary>
        /// Method for cast Nightmare ability
        /// </summary>
        public void CastNightmareAbility() =>
            Console.WriteLine("Nightmare ability is used.");

        /// <summary>
        /// Method for cast Brain Sap ability
        /// </summary>
        public void CastBrainSapAbility() =>
            Console.WriteLine("Brain Sap ability is used.");
    }
}