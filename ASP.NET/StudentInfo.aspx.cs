using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student_info
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sub1 = Convert.ToInt32(TextBox1.Text);
            int sub2 = Convert.ToInt32(TextBox2.Text);
            int sub3 = Convert.ToInt32(TextBox3.Text);
            int total ;
            float per;
            string grade;
            
            total = sub1 + sub2 + sub3;
            per = (total / 300f) * 100f;
            if(per>=80)
            {
                grade = "A";
            }
            else if(per>=70 && per <=80)
            {
                grade = "B";
            }
            else if(per>=60 && per <=70)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }
            Label1.Text = "Total Subject Marks : " + total+"<br>"+"Percent : "+per+"<br>"+"Grade : "+grade;
            

        }
    }
}