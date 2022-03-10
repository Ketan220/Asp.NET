using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class a1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Username:-" + TextBox1.Text;

            //checkbox 
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Course:" );
            if(CheckBox1.Checked ==true)
            {
                sb.Append(" "+CheckBox1.Text);
            }
            if(CheckBox2.Checked ==true)
            {
                sb.Append (" "+CheckBox2 .Text);    
            }
            Label2.Text= sb.ToString();

            //radiobutton
            if (RadioButton1.Checked == true)
            {
                Label3.Text = "Gender" + RadioButton1.Text;
            }
            else if (RadioButton2.Checked == true)
            {
                Label3.Text = "Gender:-" + RadioButton2.Text;
            }

            //Dropdownlist
            Label4.Text = "City:-" + DropDownList1.Text;

            //ListBox
            Label5.Text = "State:-" + ListBox1.Text;
        }

       
    }
}