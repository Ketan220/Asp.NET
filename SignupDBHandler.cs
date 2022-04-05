using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication37.Models;
using System.Configuration;

namespace WebApplication37.Models
{
        public class SignupDBHandler
        {
            private SqlConnection con;
            private void connection()
            {
            string constring = ConfigurationManager.ConnectionStrings["mycon"].ToString();
            con = new SqlConnection(constring);
            }

            // 1. ********** Insert Item **********
            public bool InsertItem(SignupModel iList)
            {
                connection();
                string query = "INSERT INTO Signup VALUES('" + iList.uname + "','" + iList.upass + "','" + iList.course + "','" + iList.city + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i >= 1)
                    return true;
                else
                    return false;
            }


            // 2. ********** Get All Item List **********
            public Boolean GetItemList(SignupModel sm)
            {
                connection();
                List<SignupModel> iList = new List<SignupModel>();

                string query = "SELECT * FROM signup where uname='" + sm.uname + "' and  upass='"+sm.upass+"' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                adapter.Fill(dt);
                con.Close();
                string un = null;
                foreach (DataRow dr in dt.Rows)
                {
                    un = Convert.ToString(dr["uname"]);

                }
                if (un == null)
                    return false;
                else
                    return true;
            }
        }
}