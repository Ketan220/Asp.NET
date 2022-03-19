using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class WebForm3disconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //step 1- creating  a connection
            string cn = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;integrated security=true;database=test";
            SqlConnection con = new SqlConnection(cn);

            //step 2- creating a sqldataadapter
            SqlDataAdapter da = new SqlDataAdapter("select * from students",con);

            //step 3 - create an object of dataset class
            DataSet ds = new DataSet();

            //step 4 - fill the dataset with fill method of sqldataadapter 
            // this fill method will open and close the connection automatically
            da.Fill(ds, "students");

            //step 5 - display the records from data table student on web form
            Response.Write("<h1 align=center >Details of student are </h1><hr>");
            Response.Write("<table width=70% border=1 align=center>");
            Response.Write("<tr>");
            Response.Write("<th>Student Image </th>");
            Response.Write("<th>Roll Number</th>");
            Response.Write("<th>Student Name</th>");
            Response.Write("<th>Marks Obtained</th>");
            Response.Write("</tr>");

            foreach (DataRow dr in ds.Tables["students"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                string simage = dr["studentimg"].ToString();
                Response.Write("<center><img src=" + simage + " width=100 height=60 /></center>");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["rno"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["name"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(dr["marks"].ToString());
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");


        }
    }
}