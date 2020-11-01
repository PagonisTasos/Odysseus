using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a copy of this string to lowercase.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">Index in the string from which to tranform to lowercase.</param>
    /// <returns>Copy of this string to lowercase.</returns>
    public static string ToLower(this String @this, int startIndex)
    {
        if (@this == null) return @this;
        if (startIndex >= @this.Length) return @this;

        return @this.Substring(0, startIndex) + @this.Substring(startIndex).ToLower();
    }
}
