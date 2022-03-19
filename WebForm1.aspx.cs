using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SampleLibrary;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Algebra al = new Algebra();
            double n1 = Convert.ToInt32(TextBox1.Text);
            double n2 = Convert.ToInt32(TextBox2.Text);
            double res = al.Addition(n1, n2);
            Label1.Text = "Additon =" + res.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Algebra al=new Algebra();   
            double n1=Convert.ToInt32(TextBox1.Text);
            double n2=Convert.ToInt32(TextBox2.Text);
            double res=al.Substraction(n1, n2); 
            Label1.Text="Substraction ="+res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Algebra al = new Algebra();
            double n1 = Convert.ToInt32(TextBox1.Text);
            double n2 = Convert.ToInt32(TextBox2.Text);
            double res = al.Multiplication(n1, n2);
            Label1.Text = "Multiplication =" + res.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Algebra al = new Algebra();
            double n1 = Convert.ToInt32(TextBox1.Text);
            double n2 = Convert.ToInt32(TextBox2.Text);
            double res = al.Division(n1, n2);
            Label1.Text = "Division =" + res.ToString();

        }
    }
}