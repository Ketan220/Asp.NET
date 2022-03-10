using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Username:-" + TextBox1.Text;
            Label2.Text = "Password:-" + TextBox2.Text;
            Label3.Text = "Address:-" + TextBox3.Text;
            Label4.Text = "DOB:-" + TextBox4.Text;
            Label5.Text = "Email:-:" + TextBox5.Text;

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //write code to go to register page

            //Response.Redirect("WebForm1.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}