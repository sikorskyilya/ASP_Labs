using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class CHResearchController : Controller
    {
        public ActionResult Index()
        {
            return Content("GET:/");
        }

        [OutputCache(Duration = 5), HttpGet]
        public ActionResult AD()
        {
            long t = DateTime.Now.ToBinary();
            return Content($"GET:/AD:{t}");
        }

        [OutputCache(Duration = 7, VaryByParam = "x;y"), HttpPost]
        public ActionResult AP(string x, string y)
        {
            long t = DateTime.Now.ToBinary();
            return Content($"GET:/AP:{t}:{x}:{y}");
        }
    }
}