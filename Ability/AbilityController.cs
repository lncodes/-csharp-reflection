namespace Lncodes.Example.Reflection
{
    public abstract class AbilityController
    {
        protected readonly uint Damage;
        protected readonly float Cooldown;

        [Ignore]
        protected readonly float Range;

        // Constructor
        protected AbilityController(uint damage, float cooldown, float range) =>
            (Damage, Cooldown, Range) = (damage, cooldown, range);
    }
}