using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_form_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Attendance> a = new Dictionary<int, Attendance>();
        private void button1_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,textBox4.Text);
            a.Add(Convert.ToInt32(textBox1.Text),att);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalp = 0;
            int totala = 0;
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Attendance>kvp in a)
            {
                if(kvp.Value.attend =="A")
                {
                    totala++;
                }
               else if(kvp.Value.attend=="P")
                 {
                    totalp++;
                }
                
                sb.Append("Student Roll No : " + kvp.Key + "\n");
                sb.Append("Student Name : " + kvp.Value.name + "\n");
                sb.Append("Student Date : " + kvp.Value.date + "\n");
                sb.Append("Student Attendance : " + kvp.Value.attend + "\n");
                sb.Append("--------------------------\n");

            }
            sb.Append("Student Present : " + totalp + "\n");
            sb.Append("Student Absent : " + totala + "\n");

            label5.Text = sb.ToString();
        }
    }
}
