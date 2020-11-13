using System.Web;
using System.Web.Mvc;

public static partial class Extensions
{
    public static string RenderViewToString(this ControllerContext @this, ActionResult actionResult)
    {
        // Create memory writer.
        var sb = new System.Text.StringBuilder();
        var memWriter = new System.IO.StringWriter(sb);

        // Create fake http context to render the view.
        var fakeResponse = new HttpResponse(memWriter);
        var fakeContext = new HttpContext(
            HttpContext.Current.Request,
            fakeResponse
            );
        var fakeControllerContext = new ControllerContext(
            new HttpContextWrapper(fakeContext),
            @this.RouteData,
            @this.Controller
            );
        var oldContext = HttpContext.Current;
        HttpContext.Current = fakeContext;

        // Render the view.
        actionResult.ExecuteResult(fakeControllerContext);

        // Restore old context.
        HttpContext.Current = oldContext;

        // Flush memory and return output.
        memWriter.Flush();
        return sb.ToString();

    }
}
