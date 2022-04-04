using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication36.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;

        public void connection()
        {
            string constring=ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            con = new SqlConnection(constring);
        }

        // 2. ********** Get All Item List **********
        public List<ItemModel> GetItemList()
        {
            connection();
            List<ItemModel> iList = new List<ItemModel>();
            string qr = "select * from ItemList";
            SqlCommand cmd = new SqlCommand(qr, con);   
            SqlDataAdapter ad=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();

            con.Open(); 
            ad.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
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
        public bool InsertItem(ItemModel iList)
        {
            connection();
            string qr = "Insert into ItemList values('" + iList.Name + "','" + iList.Category + "','" + iList.Price + "')";
            SqlCommand cmd =new SqlCommand(qr,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();

            if(i>=1)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

        // 3. ********** Update Item Details **********
        public bool UpdateItem(ItemModel iList)
        {
            connection();
            string qr="Update ItemList Set Name='"+iList.Name+"',Category='"+iList.Category+"',Price='"+iList.Price+"' where ID='"+iList.ID+"'";
            SqlCommand cmd =new SqlCommand(qr, con);

            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();

            if(i>=0)
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
            string qr = "DELETE FROM ItemList WHERE ID = " + id;

            SqlCommand cmd = new SqlCommand(qr, con);
            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();

            if(i>=1)
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