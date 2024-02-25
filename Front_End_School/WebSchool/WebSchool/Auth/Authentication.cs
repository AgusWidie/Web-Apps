﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace WebSchool.Auth
{
    public class Authentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext.HttpContext.Session.GetString("UserName") == null) {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                                              { "Controller", "Login" },
                                              { "Action", "Index" }
                                         });
            }

        }
    }

}