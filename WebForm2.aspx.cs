using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "temporary cookie added to client machine";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                Label1.Text = "username : " + uname;
            }
            else
            {
                Label1.Text = "no cookie exist";
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            HttpCookie cookie2 = new HttpCookie("cook1");
            cookie2.Values.Add("username", TextBox1.Text);
            DateTime dt =  DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 2, 0);
            cookie2.Expires = dt.Add(ts);
            Response.Cookies.Add(cookie2);
            Label1.Text = "temporary cookie added to client machine";


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie2 = Request.Cookies["cook1"];
            if (cookie2 != null)
            {
                string uname = cookie2.Values["username"].ToString();
                
                Label1.Text = "username : " + uname;
            
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }

        }
    }
}