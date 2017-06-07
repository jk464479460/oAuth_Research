using System;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string authorization = Request.Headers["Authorization"];
            if (string.IsNullOrWhiteSpace(authorization))
            {
                string access_token = "";
                string method = Request.HttpMethod.ToLower();
                if (method == "post")
                {
                    access_token = Request.Form["access_token"];
                }
                else if (method == "get")
                {
                    access_token = Request.QueryString["access_token"];
                }
                if (!string.IsNullOrWhiteSpace(access_token))
                {
                    Request.Headers.Set("Authorization", "Bearer " + access_token);
                }
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}