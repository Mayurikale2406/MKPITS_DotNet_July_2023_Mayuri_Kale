using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            student stud = new student();
            stud.name = textBox1.Text;
            stud.rollno = Convert.ToInt32(textBox2.Text);
            stud.mark1 = Convert.ToInt32(textBox3.Text);
            stud.mark2 = Convert.ToInt32(textBox4.Text);
            stud.mark3 = Convert.ToInt32(textBox5.Text);

            stud.total = stud.mark1 + stud.mark2 + stud.mark3;
            stud.per = (stud.total / 300f) * 100f;

            if(stud.per>75)
            {
                stud.grade = "destinction";
            }
            else if(stud.per<75 && stud.per>65)
            {
                stud.grade = "first class";
            }
            else if(stud.per<=65 && stud.per>50)
            {
                stud.grade = "second class";
            }
            else
            {
                stud.grade = "fail";
            }
            
            StringBuilder sb = new StringBuilder();
            sb.Append("name : " + stud.name + "\n");
            sb.Append("roll no : " + stud.rollno + "\n");
            sb.Append("total of three subject mark : " + stud.total + "\n");
            sb.Append("percentage : " + stud.per + "\n");
            sb.Append("grade : " + stud.grade + "\n");

            label7.Text = sb.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
