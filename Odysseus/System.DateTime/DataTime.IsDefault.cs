using System;
public static partial class Extensions
{
    /// <summary>
    ///     An extension method that checks if the value is default(Datetime).
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>True if the value is  default(Datetime).</returns>
    public static bool IsDefault(this DateTime @this)
    {
        return @this == default(DateTime);
    }
}