using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.App_Code
{
    public class PutHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.Form.Count == 2)
            {
                string param1 = request.Form[0];
                string param2 = request.Form[1];
                response.Write($"PUT-Http-SIA: ParmA = {param1}, ParmB = {param2}");
            }

            else { response.Write("put HttpHandler"); }
        }
    }
}