using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ragistration_form_one
{
    public partial class ragistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string name = TextBox1.Text;
            string g = null;
            if (RadioButton1.Checked)
                g = RadioButton1.Text;
            else if (RadioButton2.Checked)
                g = RadioButton2.Text;
            else if (RadioButton3.Checked)
                g = RadioButton3.Text;

            string c= null;
            if (RadioButton4.Checked)
                c = RadioButton4.Text;
            else if (RadioButton5.Checked)
                c = RadioButton5.Text;
            

            sb.Append("Name  : " + name + "<br>");
            sb.Append("Gender : " + g + "<br>");
            sb.Append("Category : " + c + "<br>");
            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("City : " + DropDownList3.Text + "<br>");

            Label1.Text = sb.ToString();


        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Up");
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Mumbai");

                    break;

                case "USA":
                    DropDownList2.Items.Add("Florida");
                    DropDownList3.Items.Add("LA");
                    DropDownList3.Items.Add("New York");
                break;
            }
        }      
    }
}