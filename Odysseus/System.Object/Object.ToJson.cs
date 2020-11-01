using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class Extensions
{
    /// <summary>
    ///     Serializes the object to Json.
    /// </summary>
    /// <typeparam name="T">Type of the object to be serialized</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="formatting">Formatting of the json string (indented or none)</param>
    /// <returns>A string containing the object in json format.</returns>
    public static string ToJson<T>(this T @this, Formatting formatting = Formatting.None)
    {
        return JsonConvert.SerializeObject(@this, formatting);
    }
}

