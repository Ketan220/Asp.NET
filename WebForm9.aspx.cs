using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int bs;
            bs=Convert.ToInt32(TextBox2.Text);
            string designation=TextBox3.Text;

            int bonous = 0;
            if (designation == "manager")
            {
                bonous = 5000;
            }
            else if (designation =="clerk")
            {
                bonous = 2000;
            }
            else if(designation =="poen")
            {
                bonous = 1000;
            }

            int total = 0;
            total = bs + bonous;

            Label1.Text = "Empname=" + name;
            Label2.Text = "Designation=" + designation;
            Label3.Text = "Total salary bs+bonous=" + total;
            
        }
    }
}