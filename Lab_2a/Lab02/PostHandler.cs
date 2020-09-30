using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab02
{
    public class PostHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //HttpRequest request = context.Request;
            //HttpResponse response = context.Response;
            //if (request.Form.Count == 2)
            //{
            //    string param1 = request.Form[0];
            //    string param2 = request.Form[1];
            //    response.Write($"POST-Http-SIA: ParmA = {param1}, ParmB = {param2}");
            //}

            //else { response.Write("Post HttpHandler"); }
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string paramA = request.Params["parmA"];
            string paramB = request.Params["parmB"];

            StreamReader reader = new StreamReader(request.InputStream);
            String inputString = reader.ReadToEnd();

            response.Write(inputString);
        }

        public bool IsReusable => false;
    }
}