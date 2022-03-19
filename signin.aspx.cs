using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        static String str = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;integrated security=true;database=test";
        SqlConnection con = new SqlConnection(str);

        protected void Button1_Click(object sender, EventArgs e)
        {
            string qr = "select count(*) from signup1 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            SqlCommand command = new SqlCommand(qr, con);
            con.Open();
            int res = Convert.ToInt32(command.ExecuteScalar());
            if (res == 0)
            {
                Label1.Text = "invalid credentials , try again.....";
            }
            else
            {
                //  Label1.Text = "login successfull";
                Response.Redirect("WebForm2.aspx");




            }
        }
    }
}