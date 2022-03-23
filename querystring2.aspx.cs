using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class querystring2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve query string value 
            string username=Request.QueryString["uname"].ToString();
            Label1.Text = username;
        }
    }
}