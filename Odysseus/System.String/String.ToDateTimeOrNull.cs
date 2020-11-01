using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    /// A string extension method that converts the @this to a valid date time or null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTime?</returns>
    public static DateTime? ToDateTimeOrNull(this string @this)
    {
        if (DateTime.TryParse(@this, out DateTime date))
        {
            return date;
        }

        return null;
    }

    /// <summary>
    /// A string extension method that converts the @this to a valid date time or null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="format">The exact format of the date.</param>
    /// <returns></returns>
    public static DateTime? ToDateTimeOrNull(this string @this, string format)
    {
        return DateTime.TryParseExact(@this,
                                      format,
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None,
                                      out DateTime date) 
            ? (DateTime?)date 
            : null;
    }
}