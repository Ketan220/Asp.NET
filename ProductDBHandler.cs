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
    public class ProductDBHandler
    {
        private SqlConnection con;

        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["mycon"].ToString();
            con = new SqlConnection(constring);
        }

        // 2. ********** Get All Item List **********
        public List<ProductModel> GetItemList()
        {
            connection();
            List<ProductModel> iList = new List<ProductModel>();
            string qr = "select * from product";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            ad.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ProductModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;


        }

        // 2. ********** Insert Item **********
        public bool InsertItem(ProductModel iList)
        {
            connection();
            string qr = "Insert into product values('" + iList.Name + "','" + iList.Category + "','" + iList.Price + "')";
            SqlCommand cmd = new SqlCommand(qr, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 3. ********** Update Item Details **********
        public bool UpdateItem(ProductModel iList)
        {
            connection();
            string qr = "Update product Set Name='" + iList.Name + "',Category='" + iList.Category + "',Price='" + iList.Price + "' where ID='" + iList.ID + "'";
            SqlCommand cmd = new SqlCommand(qr, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 4. ********** Delete Item **********
        public bool DeleteItem(int id)
        {
            connection();
            string qr = "DELETE FROM product WHERE ID = " + id;

            SqlCommand cmd = new SqlCommand(qr, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}