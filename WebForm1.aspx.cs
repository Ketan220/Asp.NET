using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cn = (String)Application["companyname"];
            String ct = (String)Application["companycity"];
            int cnt = (int)Application["counter"];
            cnt = cnt + 1;
            Response.Write("you are visitor no.=" + cnt.ToString());
            Response.Write("<hr>company name= " + cn);
            Response.Write("<hr>company city=" + ct);

            Application["counter"] = cnt;
            
            //reading session varible values
            string uname=Session["uname"].ToString();
            int ucnt = (int)Session["usercount"];
            ucnt = ucnt + 1;
            Session["usercount"] = ucnt;
            Response.Write("<hr>User visiting this page=" + ucnt.ToString());
            Response.Write("<br>uname=" + uname);

           
        }
    }
}