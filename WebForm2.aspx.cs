using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static string cn = "data source=DESKTOP-JEOJBC2\\SQLEXPRESS;integrated security=true;database=test";
        SqlConnection con = new SqlConnection(cn);
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string qr = "select * from signup1 ";
            SqlCommand command = new SqlCommand(qr, con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            sb.Append("<table border=1 align=center width=80% ");
            sb.Append("<tr><th>userid</th><th>username</th><th>gender</th><th>hobby1</th><th>hobby2</th><th>city</th></tr>");

            while (dr.Read())
            {
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append(dr["userid"].ToString());
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append(dr["username"].ToString());
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append(dr["gender"].ToString());
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append(dr["hobby1"].ToString());
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append(dr["hobby2"].ToString());
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append(dr["city"].ToString());
                sb.Append("</td>");

                sb.Append("</tr>");
            }
            sb.Append("</table>");
            Label1.Text = sb.ToString();

        }
    }
}