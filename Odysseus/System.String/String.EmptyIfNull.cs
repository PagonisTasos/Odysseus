using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns empty string, if string is null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>This string or empty string if string is null.</returns>
    public static string EmptyIfNull(this String @this)
    {
        return String.IsNullOrEmpty(@this) ? String.Empty : @this;
    }
}
