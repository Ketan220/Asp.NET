using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2, res = 0;
            n1=Convert.ToInt32(TextBox1.Text);
            n2=Convert.ToInt32(TextBox2.Text);
            string ch = TextBox3.Text;

            switch (ch)
            {
                case "+":
                    res=n1+ n2;
                    break;

                case "-":
                    res = n1 - n2;
                    break;

                case "*":
                    res = n1 * n2;
                    break;

                case "/":
                    res = n1 / n2;
                    break;
            }

            Label1.Text = "Result=" + res;
        }
    }
}