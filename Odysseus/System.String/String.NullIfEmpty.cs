using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns null if string is empty.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>This string or null if string is empty.</returns>
    public static string NullIfEmpty(this String @this)
    {
        return String.IsNullOrEmpty(@this) ? null : @this;
    }
}
