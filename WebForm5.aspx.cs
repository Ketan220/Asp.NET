using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, total = 0;
            float per;
            m1 = Convert.ToInt32(TextBox1.Text);
            m2 = Convert.ToInt32(TextBox1.Text);
            m3 = Convert.ToInt32(TextBox1.Text);

            total = m1 + m2 + m3;
            per = ((total / 0.3f) * 0.1f);


            string res=Label2.Text;
            if (per >= 75 && per <= 100)
            {
                res="A";
            }
            else if (per >= 50 && per < 75)
            {
                res="B";
            }



            Label1.Text = "Total marks="+total;
            Label2.Text = "Percentage=" + per;
            Label3.Text = "Grade=" + res;
        
           

        }
    }
}