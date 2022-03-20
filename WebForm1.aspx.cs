using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //step 1- creating  a connection
            string cn = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;integrated security=true;database=test";
            SqlConnection con = new SqlConnection(cn);

            //step 2- creating a sqldataadapter
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);

            //step 3 - create an object of dataset class
            DataSet ds=new DataSet();

            //step 4 - fill the dataset with fill method of sqldataadapter 
            // this fill method will open and close the connection automatically
            da.Fill(ds,"employee");

            //step 5 - display the records from data table student on web form
            Response.Write("<h1 align=center>Details of students are</h1><hr>");
            Response.Write("<table align=center width=70% border=1");
            Response.Write("<tr>");
            Response.Write("<th>empimage</th>");
            Response.Write("<th>empno</th>");
            Response.Write("<th>empname</th>");
            Response.Write("<th>empdesignation</th>");
            Response.Write("<th>empsalary</th>");
            Response.Write("</tr>");

            foreach(DataRow dr in ds.Tables["employee"].Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                string simage=dr["empimage"].ToString();
                Response.Write("<center><img src=" + simage + " align=center width=100 height=70/> <center/>");
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["empno"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["empname"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["empdesignation"].ToString());
                Response.Write("</td>");

                Response.Write("<td>");
                Response.Write(dr["empsalary"].ToString());
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");

        }
    }
}