using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prime_num
{
    public partial class PrimeNumaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int flag = 0;

            for (int count = 2; count < num; count++)
            {
                if (num % count == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Label1.Text = "it is prime number";

            }
            else
            {
                Label1.Text = "it is not prime number";
            }

        }
    }
}
