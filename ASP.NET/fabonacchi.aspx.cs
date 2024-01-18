using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fabonacchi_series
{
    public partial class fabonacchi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int num, count;
            int num1 = 0;
            int num2 = 1;
            int add = num1 + num2;
            
            num = Convert.ToInt32(TextBox1.Text);
            sb.Append(num1 + "," + num2 + ",");

            for(count=3;count<=num;count++)
            {
                sb.Append(add + ",");
                
                num1 = num2;
                num2 = add;
                add = num1 + num2;
           

               
            }
            Label1.Text = sb.ToString();


        }
    }
}