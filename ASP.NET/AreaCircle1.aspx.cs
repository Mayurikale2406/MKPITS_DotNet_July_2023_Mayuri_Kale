using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace area_circle
{
    public partial class AreaCircle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float area = Convert.ToSingle(TextBox1.Text);
            
            area = 3.14f * area * area;
            Label1.Text = "area of circle : " + area;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            float area = Convert.ToSingle(TextBox1.Text);
            area = 2 * 3.14f * area;
            Label2.Text = "area of circ : " + area;
        }
    }
}