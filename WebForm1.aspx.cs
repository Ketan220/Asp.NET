using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //create an object of sqlconnection class for creating 
        //connection between this web page and sqlserver 

        static string cn = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;Integrated security=true;database=test";

        SqlConnection con = new SqlConnection(cn);
       
        
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string qr = "insert into student(rno,name) values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
                SqlCommand command = new SqlCommand(qr, con);

                //in connected environment you have to open the connection first
                con.Open();

                //execute the insert query using executenonquery method of sqlcommand class
                command.ExecuteNonQuery();
                Label1.Text = "Record saved Sucessfully.";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
            }
            catch (Exception ex)
            {
                Label1 .Text=ex.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                string qr = "update  student set name='" + TextBox2.Text + "' where rno='" + TextBox1.Text + "'";
                SqlCommand command = new SqlCommand(qr, con);

                //in connected environment you have to open the connection first
                con.Open();

                //execute the insert query using executenonquery method of sqlcommand class
                command.ExecuteNonQuery();
                Label1.Text = "Record updated successfully";
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

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            string qr="delete from student where name='"+TextBox2.Text+"' or rno='"+TextBox1.Text+"'";
            SqlCommand command = new SqlCommand(qr,con);

            try
            {

                //in connected environment you have to open the connection first
                con.Open();

                //execute the insert query using executenonquery method of sqlcommand class
                command.ExecuteNonQuery();
                Label1.Text = "record deleted successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text=ee.ToString();  
            }
            finally
            {
                con.Close();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            try
            {
                string qr = "select * from student where rno='" + TextBox1.Text + "'";
                SqlCommand command = new SqlCommand(qr, con);

                con.Open();

                SqlDataReader dr =command.ExecuteReader();
                int flag = 0;
                while(dr.Read())
                {
                    Label1.Text = "";
                    flag = 1;
                    TextBox2.Text=dr["name"].ToString();

                }
                if(flag==0)
                {
                    Label1.Text = "No record found";
                }
                dr.Close();
                
            }
            catch(Exception ee)
            {
                Label1.Text= ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}