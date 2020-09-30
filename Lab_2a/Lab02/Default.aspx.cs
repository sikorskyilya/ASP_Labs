using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/get.SIA?ParmA=AAA&ParmB=BBB");
            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5001/lab_1a/get.SIA?ParmA=AAA&ParmB=BBB");
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected  void PostButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/post.SIA");
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5001/lab_1a/post.SIA");
            request.Method = "POST";
            string postData = "ParmA=AAA&ParmB=BBB";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/put.SIA");
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5001/lab_1a/put.SIA");
            request.Method = "PUT";

            string postData = "ParmA=AAA&ParmB=BBB";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());

        }

        protected void ErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/err.SIA?ParmA=AAA&ParmB=BBB");
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5001/lab_1a/err.SIA?ParmA=AAA&ParmB=BBB");
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/err.SVV");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Response.Write(reader.ReadToEnd());
            }
            catch (WebException error)
            {
                Response.Write(error.Status);
                Response.Write("<br/>" + error.Message);
                Response.Write("<br/>" + error.TargetSite);
                Response.Write("<br/>" + error.Source); 
            }
        }

        protected void HtmlButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/mul.SIA");
            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5001/Lab02/mul.SIA");
            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5001/lab_1a/mul.SIA");
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }
    }
}