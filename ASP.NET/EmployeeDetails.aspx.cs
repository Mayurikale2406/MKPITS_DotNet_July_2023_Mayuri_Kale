using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employee_form
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int salary = Convert.ToInt32(TextBox2.Text);
            string designation = TextBox3.Text;
            float hra = 0;
            float da=0;
            float total = 0;
            if(designation=="Manager")
            {
                hra = salary * 0.45f;
                da =  salary * 0.35f;
                total = salary+hra + da;
                
            }
            else if(designation=="Peon")
            {
                hra = salary * 0.25f;
                da = salary * 0.15f;
                total = salary + hra + da;
            }
            Label1.Text = "HRA : " + hra;
            Label2.Text = "DA : " + da;
            Label3.Text = "Total Salary : " + total;
        }
    }
}