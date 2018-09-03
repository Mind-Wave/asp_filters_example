using System;
using System.Web.Mvc;

namespace AnipchenkoASPNETFilters
{
    class MyFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var cookie = filterContext.HttpContext.Request.Cookies["key"];

            if(cookie == null)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}