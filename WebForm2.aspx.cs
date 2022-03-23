using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cn=Application["companyname"].ToString();
            string ad=Application["address"].ToString();
            int cnt = (int)Application["count"];
            cnt++;
            Application["count"] = cnt;
            Response.Write("welcome to" + cn +"<br>");
            Response.Write("at" + ad +"<br>");
            Response.Write("no. of count" + cnt.ToString() + "<br>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Label1.Text = "registered successfully";

        }
    }
}