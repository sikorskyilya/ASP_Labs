using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5.Controllers
{
    public class CResearchController : Controller
    {
        public string Index()
        {
            return "GET:/";
        }

        public string C01()
        {
            return "GET:/С01";
        }

        public string C02()
        {
            string status = HttpContext.Response.StatusCode.ToString();
            string body;
            string method = Request.HttpMethod;
            string header = Request.Headers.ToString();
            string uri = Request.Url.AbsoluteUri;
            string param = Request.QueryString["param"];

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"status: {status}; " +
                $"body: {body}; " +
                $"method: {method}; " +
                $"header: {header}; " +
                $"uri: {uri}; " +
                $"param: {param}";
        }
    }
}