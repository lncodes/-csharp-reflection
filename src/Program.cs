using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Lncodes.Example.Reflection
{
    public class Program
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected Program() { }

        /// <summary>
        /// Main Program
        /// </summary>
        private static void Main()
        {
            var abilityId = GetRandomAbilityTypesId();
            var abilityController = CreateAbilityTypesById(abilityId);
            ShowAbilityData(abilityController);
            CastAllAbility(abilityController);
        }

        /// <summary>
        /// Method for pic random hero
        /// </summary>
        /// <returns cref="AbilityController"></returns>
        /// <exception cref="Exception">Thrown when random value > 2</exception>
        private static AbilityController CreateAbilityTypesById(int abilityTypesId)
        {
            switch (abilityTypesId)
            {
                case 0:
                    return Activator.CreateInstance<AbaddonAbilityController>();
                case 1:
                    return Activator.CreateInstance<BaneAbilityController>();
                case 2:
                    return Activator.CreateInstance<FlameLordAbilityController>();
                default:
                    throw new ArgumentOutOfRangeException(nameof(abilityTypesId));
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

        /// <summary>
        /// Method for random ability types id
        /// </summary>
        /// <returns cref=int></returns>
        private static int GetRandomAbilityTypesId()
        {
            var ammountOfAbilityTypes = 3;
            return RandomNumberGenerator.GetInt32(ammountOfAbilityTypes);
        }
    }
}