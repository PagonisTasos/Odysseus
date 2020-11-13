using System.Web.Mvc;

public static partial class Extensions
{
    
    public static string RenderViewToString(this ControllerContext @this, string viewName, object model)
    {
        var viewData = new ViewDataDictionary(model);

        using(var sw = new System.IO.StringWriter())
        {
            ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(@this, viewName);
            ViewContext viewContext = new ViewContext(@this, viewResult.View, viewData, new TempDataDictionary(), sw);

            viewResult.View.Render(viewContext, sw);

            return sw.GetStringBuilder().ToString();
        }
    }
}