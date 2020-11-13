using System;
using System.Linq;
using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     Replaces spaces with dashes and filters out all letters but eng, digits and underscore.
    /// </summary>
    /// <param name="this"></param>
    /// <returns>A string composed of eng chars, digits, - and _</returns>
    public static string ToFriendlyUrl(this string @this)
    {
        var allowed = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_";

        return 
            @this?
            .Replace(" ", "-")
            .Where(@char => allowed.IndexOf(@char) > -1)
            .Where((@char, index) => {
                //filter out multiple consecutive dashes or underscores
                var isDash = @char != '-';
                var isUnderscore = @char != '_';
                var nextCharExists = @this.Length > index + 1;
                return !isDash && !isUnderscore || !nextCharExists || @this[index] != @this[index + 1];
            })
            .StringJoin("")
            ;
    }
}