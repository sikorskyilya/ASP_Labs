using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4
{
    public static class Helper
    {
        public static MvcHtmlString UpdateHelper(this HtmlHelper html, string parm)
        {
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");

            TagBuilder div = new TagBuilder("div");
            form.InnerHtml += div.ToString();

            TagBuilder p = new TagBuilder("p");
            form.InnerHtml += p.ToString();

            TagBuilder input = new TagBuilder("input");
            input.MergeAttribute("type", "number");
            input.MergeAttribute("id", "id");
            input.MergeAttribute("name", "id");
            input.MergeAttribute("min", "0");
            form.InnerHtml += input.ToString();

            form.InnerHtml += p.ToString();

            input = new TagBuilder("input");
            input.MergeAttribute("type", "text");
            input.MergeAttribute("id", "surname");
            input.MergeAttribute("name", "surname");
            form.InnerHtml += input.ToString();

            form.InnerHtml += p.ToString();

            input = new TagBuilder("input");
            input.MergeAttribute("type", "number");
            input.MergeAttribute("id", "number");
            input.MergeAttribute("name", "number");
            input.MergeAttribute("min", "0");
            input.MergeAttribute("max", "999999999");
            form.InnerHtml += input.ToString();

            form.InnerHtml += p.ToString();

            input = new TagBuilder("input");
            input.MergeAttribute("type", "submit");
            form.InnerHtml += input.ToString();

            return MvcHtmlString.Create(form.ToString());
        }
    }
}