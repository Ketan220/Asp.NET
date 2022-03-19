using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using adolibrary;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentclass s1=new studentclass();

            string str = s1.insertdata(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
            Label1.Text = str;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            studentclass s1 = new studentclass();

            string str = s1.updatedata(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
            Label1.Text = str;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            studentclass s1 = new studentclass();

            string str = s1.deletedata(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
            Label1.Text = str;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            studentclass s1 = new studentclass();

            string str = s1.searchdata(Convert.ToInt32(TextBox1.Text));
            TextBox2.Text = str;
            Label1.Text = str;
        }
    }
}