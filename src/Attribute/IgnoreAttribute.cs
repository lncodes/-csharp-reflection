using System;

namespace Lncodes.Example.Reflection;

/// <summary>
/// Indicates that a field should be ignored during reflection operations.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class IgnoreAttribute : Attribute;