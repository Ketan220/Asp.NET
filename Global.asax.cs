using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication13
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Application["companyname"] = "mkplacement";
            Application["address"] = "Bharat nagar nagpur";
            Application["count"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            Session["usercount"] = 0;
            Session["username"] = "";
            Session["email"]= "";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

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