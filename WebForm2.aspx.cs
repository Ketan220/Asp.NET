using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication43
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlReader xReader=XmlReader.Create(Server.MapPath("~/Tenders.xml"));
            while(xReader.Read())
            {
                switch(xReader.NodeType)
                {
                    case XmlNodeType.Element:
                        ListBox1.Items.Add("<"+xReader.Name+">");
                        break;
                    case XmlNodeType.Text:
                        ListBox1.Items.Add(xReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        ListBox1.Items.Add("<" + xReader.Name + ">");
                        break ;
                }
            }

        }
    }
}