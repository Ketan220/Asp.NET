using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using adolibrary1;

namespace WebApplication14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            studentsclass s1 = new studentsclass();
            String str = s1.insertdata(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, Convert.ToInt32(TextBox4.Text), Convert.ToInt32(TextBox5.Text), Convert.ToInt32(TextBox6.Text));
            Label1.Text = str;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            studentsclass s1 = new studentsclass();
            String str = s1.updatedata(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, Convert.ToInt32(TextBox4.Text), Convert.ToInt32(TextBox5.Text), Convert.ToInt32(TextBox6.Text));
            Label1.Text = str;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            studentsclass s1 = new studentsclass();
            String str = s1.deletedata(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, Convert.ToInt32(TextBox4.Text), Convert.ToInt32(TextBox5.Text), Convert.ToInt32(TextBox6.Text));
            Label1.Text = str;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            studentsclass s1 = new studentsclass();
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = s1.searchdata(Convert.ToInt32(TextBox1.Text));
            TextBox2.Text = ds.Tables["mkpit"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["mkpit"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["mkpit"].Rows[0].ItemArray[3].ToString();
            TextBox5.Text = ds.Tables["mkpit"].Rows[0].ItemArray[4].ToString();
            TextBox6.Text = ds.Tables["mkpit"].Rows[0].ItemArray[5].ToString();

        }
    }
}