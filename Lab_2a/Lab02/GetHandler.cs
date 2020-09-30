using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02
{
    //Param=A&&Param=B
    public class GetHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            if(request.QueryString.Count >= 2)
            {
                string parametr1 = request.QueryString[0];
                string parametr2 = request.QueryString[1];

                response.Write($"GET-Http-SIA: ParmA: {parametr1}, ParmB: {parametr2}");
            }
            else { response.Write("GET Handler"); }
        }
    }
}   