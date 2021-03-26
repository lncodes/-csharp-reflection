using System;
using System.Reflection;

namespace Lncodes.Example.Reflection
{
    class Program
    {
        static void Main()
        {
            var abilityInstance = PickRandomHeroAbility();
            ShowAbilityData(abilityInstance);
            CastAllAbility(abilityInstance);
        }

        /// <summary>
        /// Method for pic random hero
        /// </summary>
        /// <returns cref="AbilityController"></returns>
        /// <exception cref="Exception">Thrown when random value > 2</exception>
        private static AbilityController PickRandomHeroAbility()
        {
            switch (new Random().Next(3))
            {
                case 0:
                    return Activator.CreateInstance<AbaddonAbilityController>();
                case 1:
                    return Activator.CreateInstance<BaneAbilityController>();
                case 2:
                    return Activator.CreateInstance<FlameLordAbilityController>();
                default:
                    throw new Exception("Error to random hero");
            }
        }

        /// <summary>
        /// Method for show hero ability data
        /// </summary>
        /// <param name="abilityController"></param>
        private static void ShowAbilityData(AbilityController abilityController)
        {
            Console.WriteLine($"List ability data from {abilityController.GetType().Name} class :");

            FieldInfo[] fieldInfo = abilityController.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var info in fieldInfo)
            {
                if (info.GetCustomAttribute<IgnoreAttribute>() is null)
                    Console.WriteLine($"{info.Name} ability value is {info.GetValue(abilityController)}.");
                else
                    Console.WriteLine($"Can't show {info.Name} value because the Range field has Ignore costume attribute.");
            }
        }

        /// <summary>
        /// Method for cast hero ability
        /// </summary>
        /// <param name="abilityController"></param>
        private static void CastAllAbility(AbilityController abilityController)
        {
            Console.WriteLine();
            Console.WriteLine($"Cast all ability from {abilityController.GetType().Name} class :");
            MethodInfo[] methodInfo = abilityController.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            foreach (var info in methodInfo)
                info.Invoke(abilityController, null);
        }
    }
}