using Newtonsoft.Json;

public static partial class Extensions
{
    /// <summary>
    ///     Derializes the string if Json.
    /// </summary>
    /// <typeparam name="T">The type to deserialize to.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An object of the specified type.</returns>
    public static T ParseJsonAs<T>(this string @this)
    {
        return JsonConvert.DeserializeObject<T>(@this);
    }
}

