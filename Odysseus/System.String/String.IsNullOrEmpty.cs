using System;

public static partial class Extensions
{
    /// <summary>
    ///     Checks if a string is null or empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>True if the string is null or empty</returns>
    public static bool IsNullOrEmpty(this String @this)
    {
        return String.IsNullOrEmpty(@this);
    }
}
