﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class MResearchController : Controller
    {
        [HttpGet]
        public string M01()
        {
            return "GET:M01";
        }

        [HttpGet]
        public string M02()
        {
            return "GET:M02";
        }

        [HttpGet]
        public string M03()
        {
            return "GET:M03";
        }

        [HttpGet]
        public string MXX()
        {
            string[] url = Request.Url.Query.Split('/');
            string result = "";
            for (int i = 1; i < url.Length; i++)
            {
                result += "/" + url[i];
            }
            return result;
        }
    }
}