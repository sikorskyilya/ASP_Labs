using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab02.App_Code
{
    public class MulHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.HttpMethod == "GET")
            {
                string s = "<title>Laba 2</title>";
                s += "<h1>Hi!</h1>";
                response.Write(s);
            }
            else if (request.HttpMethod == "POST")
            {
                if (request.Params.Count >= 2)
                {
                    int x = 0;
                    int y = 0;
                    if (Int32.TryParse(request.Params[0], out x) && int.TryParse(request.Params[1], out y))
                    {
                        int mul = x * y;
                        response.Write(mul);
                    }
                    else { response.Write("Put only digits"); }
                }
                else { response.Write("Put 2 params"); }
            }
        }
    }
}