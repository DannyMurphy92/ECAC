using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Website.Infrastructure;

namespace Website.Helpers
{
    public static class PlaceholderHelper
    {
        public static string FgasOverviewPlaceholders(string content)
        {
            UrlHelper url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            content = content.Replace("$$FGAS_CAT1_LINK$$",url.Action("Course", "Training",new RouteValueDictionary {{"typeId", (int)TrainingType.FGas}, {"courseId", (int)FGas.Cat1}}));
            content = content.Replace("$$FGAS_CAT2_LINK$$",url.Action("Course", "Training",new RouteValueDictionary {{"typeId", (int)TrainingType.FGas}, {"courseId", (int)FGas.Cat2}}));
            content = content.Replace("$$FGAS_CAT3_LINK$$",url.Action("Course", "Training",new RouteValueDictionary {{"typeId", (int)TrainingType.FGas}, {"courseId", (int)FGas.Cat3}}));
            content = content.Replace("$$FGAS_CAT4_LINK$$",url.Action("Course", "Training",new RouteValueDictionary {{"typeId", (int)TrainingType.FGas}, {"courseId", (int)FGas.Cat4}}));
            return content;
        }
    }
}
