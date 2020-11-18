using System.Collections.Concurrent;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.WebPages;

public static partial class Extensions
{
    public static IHtmlString VersionedStyle(this HtmlHelper helper, string filePath)
    {
        var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
        return new HtmlString($"<link href=\"{urlHelper.VersionedContent(filePath)}\" rel=\"stylesheet\" />");
    }

    public static IHtmlString VersionedScript(this HtmlHelper helper, string filePath)
    {
        var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
        return new HtmlString($"<script src=\"{urlHelper.VersionedContent(filePath)}\"></script>");
    }
}
