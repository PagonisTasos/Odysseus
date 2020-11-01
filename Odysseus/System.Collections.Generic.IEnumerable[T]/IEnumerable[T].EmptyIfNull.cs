using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Returns empty collection if null.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The collection to act on.</param>
    /// <returns>the collection or empty collection if null.</returns>
    public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this)
    {
        return @this ?? Enumerable.Empty<T>();
    }
}
