using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Lncodes.Example.Reflection;

internal static class Program
{
    /// <summary>
    /// Entry point of the application.
    /// </summary>
    private static void Main()
    {
        var abilityId = GetRandomAbilityTypeId();
        var abilityController = CreateAbilityControllerById(abilityId);
        DisplayAllAbilityFields(abilityController);
        InvokeAllAbilityMethods(abilityController);
    }

    /// <summary>
    /// Creates an instance of the ability controller based on the provided ID.
    /// </summary>
    /// <param name="abilityTypeId">The ID of the ability type.</param>
    /// <returns>An instance of the appropriate ability controller.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the ID is not valid.</exception>
    private static AbilityController CreateAbilityControllerById(int abilityTypeId) =>
        abilityTypeId switch
        {
            0 => Activator.CreateInstance<AbaddonAbilityController>(),
            1 => Activator.CreateInstance<BaneAbilityController>(),
            2 => Activator.CreateInstance<FlameLordAbilityController>(),
            _ => throw new ArgumentOutOfRangeException(nameof(abilityTypeId), "Invalid ability type ID."),
        };

    /// <summary>
    /// Displays all fields of the given ability controller.
    /// </summary>
    /// <param name="abilityController">The ability controller instance.</param>
    private static void DisplayAllAbilityFields(AbilityController abilityController)
    {
        Console.WriteLine($"Display all field information from the '{abilityController.GetType().Name}' class:");
        FieldInfo[] fields = abilityController.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        for (int i = 0; i < fields.Length; i++)
        {
            Console.WriteLine($"{i + 1}. Field name: '{fields[i].Name}'");
            if (fields[i].GetCustomAttribute<IgnoreAttribute>() is null)
                Console.WriteLine($"   Value: {fields[i].GetValue(abilityController)}");
            else
                Console.WriteLine("   The value is not displayed because the field has an 'Ignore' attribute.");
        }
    }

    /// <summary>
    /// Invoke all methods of the given ability controller.
    /// </summary>
    /// <param name="abilityController">The ability controller instance.</param>
    private static void InvokeAllAbilityMethods(AbilityController abilityController)
    {
        Console.WriteLine();
        Console.WriteLine($"Display all method information from the '{abilityController.GetType().Name}' class:");
        MethodInfo[] methods = abilityController.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
        for (int i = 0; i < methods.Length; i++)
        {
            Console.WriteLine($"{i+1}. Method name: '{methods[i].Name}'");
            Console.Write("   Result: ");
            methods[i].Invoke(abilityController, null);
        }
    }

    /// <summary>
    /// Generates a random ID for the ability type.
    /// </summary>
    /// <returns>A randomly selected ability type ID.</returns>
    private static int GetRandomAbilityTypeId()
    {
        const int amountOfAbilityTypes = 3;
        return RandomNumberGenerator.GetInt32(amountOfAbilityTypes);
    }
}