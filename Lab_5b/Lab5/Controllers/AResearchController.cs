﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class AResearchController : Controller
    {
        public ActionResult Index()
        {
            return Content("GET:/");
        }

        [AAFilter]
        public ActionResult AA()
        {
            return Content("");
        }

        [ARFilter]
        public ActionResult AR()
        {
            return Content($"<p>AR</p>");
        }

        [AEFilter]
        public ActionResult AE()
        {
            throw new Exception("Exception");
            return Content($"<p>AE</p>"); ;
        }

        public class AAFilter: FilterAttribute, IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AA:OnActionExecuted</p>");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AA:OnActionExecuting</p>");
            }
        }

        public class ARFilter : FilterAttribute, IResultFilter
        {
            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AR:OnResultExecuted</p>");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AA:OnResultExecuting</p>");
            }
        }

        public class AEFilter : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AE:OnException</p>");
                ViewResult vr = new ViewResult();
                vr.ViewName = "Error";
                filterContext.Result = vr;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}