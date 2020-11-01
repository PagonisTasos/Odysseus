using System;

public static partial class Extensions
{
    /// <summary>
    ///     A Decimal extension method that rounds the @this to 2 decimal digits.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a Decimal with 2 decimal digits.</returns>
    public static Decimal ToMoney(this Decimal @this)
    {
        return Math.Round(@this, 2);
    }
}