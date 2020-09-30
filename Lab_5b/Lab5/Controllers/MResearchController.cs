using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        public ActionResult Index()
        {
            return Content("GET:/");
        }

        [Route("M01/{n:int}/{str}")]
        [HttpGet]
        public ActionResult M01(int n, string str)
        {
            return Content($"GET:M01/{n}/{str}");
        }

        [Route("M02/{b:bool}/{letters:alpha}")]
        [AcceptVerbs("get","post")]
        public ActionResult M02(bool b, string letters)
        {
            return Content($"{Request.HttpMethod}:M02/{b}/{letters}");
        }

        [Route("M03/{f:float:length(2, 5)}/{str}")]
        [AcceptVerbs("get","delete")]
        public ActionResult M03(float f, string str)
        {
            return Content($"{Request.HttpMethod}:M03/{f}/{str}");
        }

        [Route("M04/{letters:length(3, 4)}/{n:range(100, 200)}")]
        [HttpGet]
        public ActionResult M04(string letters, int n)
        {
            return Content($"GET:M04/{letters}/{n}");
        }

        //[Route("M05/{mail:regex(^\\d{3}-\\d{2}-\\d{2})}")]
        [Route("M05/{mail:regex(^\\w+@\\w+\\.\\w+$)}")]
        [HttpPost]
        public ActionResult M05(string mail)
        {
            return Content($"POST:M05/{mail}");
        }
    }
}