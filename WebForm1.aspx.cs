using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace WebApplication43
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindDataToGridview();
            }
        }
        // This method is used to bind data to dropdownlist and gridview  
        protected void BindDataToGridview()
        {
            //open the tender xml file  
            XmlTextReader xmlreader = new XmlTextReader(Server.MapPath("~/Tenders.xml"));
            //reading the xml data  
            DataSet ds = new DataSet();
            ds.ReadXml(xmlreader);
            xmlreader.Close();
            //if ds is not empty  
            if (ds.Tables.Count != 0)
            {
                //Bind Data to gridview  
                GridView1.DataSource = ds;
                GridView1.DataBind();
                // Bind Data to dropdownlist  

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "BillNo";
                DropDownList1.DataValueField = "BillNo";
                DropDownList1.DataBind();
                DropDownList2.DataSource = ds;
                DropDownList2.DataTextField = "PageNo";
                DropDownList2.DataValueField = "PageNo";
                DropDownList2.DataBind();
                DropDownList3.DataSource = ds;
                DropDownList3.DataTextField = "Activity";
                DropDownList3.DataValueField = "Activity";
                DropDownList3.DataBind();
            }
        }
    }
}