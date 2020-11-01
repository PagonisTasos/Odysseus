using System.Linq;
using System.Security.Cryptography;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     Hash the string with SHA1 algorith.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The SHA1 hash.</returns>
    public static string ToSha1Hash(this string @this)
    {
        using (var sha1 = new SHA1Managed())
        {
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(@this)); 
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

    }
}