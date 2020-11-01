using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static partial class Extensions
{
    /// <summary>
    ///     Checks if the enumerable is empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The collection to act on.</param>
    /// <returns>true if empty, false if not.</returns>
    public static bool IsEmpty<T>(this IEnumerable<T> @this)
    {
        return @this == null || !@this.Any();
    }
}
