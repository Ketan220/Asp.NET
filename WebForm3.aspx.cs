using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve session variables value
            string u = Session["username"].ToString();
            string em = Session["email"].ToString();
            int uc = Convert.ToInt32(Session["usercount"].ToString());
            uc = uc + 1;
            Session["usercount"] = uc;
            Label1.Text = u;
            Label2.Text = em;
            Label3.Text = uc.ToString();

        }
    }
}