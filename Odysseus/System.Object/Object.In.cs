using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public static partial class Extensions
{
    /// <summary>
    ///     Checks if an object is in an array
    /// </summary>
    /// <typeparam name="T">Type of the object</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">The array to check</param>
    /// <returns>True if object is in array, else false.</returns>
    public static bool In<T>(this T @this, params T[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }
}


