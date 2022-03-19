using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        static String str = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;integrated security=true;database=test";
        SqlConnection con = new SqlConnection(str);
        
        
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                String g = null;
                if (RadioButton1.Checked)
                    g = RadioButton1.Text;
                else if (RadioButton2.Checked)
                    g = RadioButton2.Text;

                String h1 = null;
                if (CheckBox1.Checked)
                    h1 = CheckBox1.Text;
                String h2 = null;
                if (CheckBox2.Checked)
                    h2 = CheckBox2.Text;
                String ct = null;
                ct = DropDownList1.Text;



                string qr = "insert into signup1(username,password,gender,hobby1,hobby2,city) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + g + "','" + h1 + "','" + h2 + "','" + ct + "')";
                SqlCommand command = new SqlCommand(qr, con);
                //in connected environment you have to open the connection first
                con.Open();
                //execute the insert query using executenonquery method of sqlcommand class
                command.ExecuteNonQuery();
                Label1.Text = "Sign up successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";       
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                //close the connection
                con.Close();
            }

        }
    }
}