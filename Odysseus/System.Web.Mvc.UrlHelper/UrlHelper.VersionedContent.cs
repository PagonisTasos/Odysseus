using System.Collections.Concurrent;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.WebPages;

public static partial class Extensions
{
    private const string CACHE_KEY = "__AssetVersions__";

    public static string VersionedContent(this UrlHelper helper, string filePath)
    {
        var cache = helper.RequestContext.HttpContext.Cache;
        var fullPath = helper.RequestContext.HttpContext.Server.MapPath(filePath);

        var version = cache.GetOrAddVersion_ToAssetCache(fullPath);

        return AppendVersion(helper.Content(filePath), version);
    }
    
    private static string AppendVersion(string contentUrl, string version)
    {
        if (string.IsNullOrEmpty(version)) return contentUrl;

        if (contentUrl.Contains("?"))
        {
            return contentUrl + "&" + version;
        }
        else
        {
            return contentUrl + "?" + version;
        }
    }

    private static string GetOrAddVersion_ToAssetCache(this Cache cache, string fullFilePath)
    {
        if (!File.Exists(fullFilePath))
        {
            return null;
        }
        var assetCache = cache.GetOrCreateAssetCache();
        string version;
        if (assetCache.ContainsKey(fullFilePath))
        {
            version = assetCache[fullFilePath];
        }
        else
        {
            version = assetCache.GetOrAdd(fullFilePath, ComputeFileHash(fullFilePath));
        }

        return version;
    }

    private static ConcurrentDictionary<string, string> GetOrCreateAssetCache(this Cache cache)
    {
        if (!(cache[CACHE_KEY] is ConcurrentDictionary<string, string> assetCache))
        {
            assetCache = new ConcurrentDictionary<string, string>();
            cache[CACHE_KEY] = assetCache;
        }

        return assetCache;
    }

    private static string ComputeFileHash(string fullFilePath)
    {
        using (var stream = File.OpenRead(fullFilePath))
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return System.Convert.ToBase64String(sha256.ComputeHash(stream));
            }
        }
    }

}
