using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = Convert.ToInt32(TextBox1.Text);//(Property/Value)
            int sq = n1 * n1;
            Label1.Text = "Square=" + sq;
        }
    }
}