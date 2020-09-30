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
                s += "<h1>Привет</h1>";
                s += "<input type='button' value='Кнопка 1'>";
                s += "<input type='button' value='Кнопка 2'>";
                s += "<input type='button' value='Кнопка 3'>";
                s += "<table style='border: 1px solid black; margin-top: 10px'>";
                s += "<thead>";
                s += "<tr>";
                s += "<th>Один</th>";
                s += "<th>Два</th>";
                s += "</tr>";
                s += "</thead>";
                s += "<tbody>";
                s += "<tr>";
                s += "<td>1</th>";
                s += "<td>2</th>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>1</th>";
                s += "<td>2</th>";
                s += "</tr>";
                s += "</body>";
                s += "</table>";
                s += "<h1>Пока</h1>";
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