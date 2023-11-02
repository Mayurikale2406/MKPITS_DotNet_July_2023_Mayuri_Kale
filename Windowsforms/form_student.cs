using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        student[] stud = new student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new student();
            stud[1] = new student();
            stud[2] = new student();
            stud[3] = new student();
            stud[4] = new student();
            stud[5] = new student();
            stud[6] = new student();
            stud[7] = new student();
            stud[8] = new student();
            stud[9] = new student();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                stud[cnt].Student_rollno = Convert.ToInt32(textBox1.Text);
                stud[cnt].Student_name = textBox2.Text;
                stud[cnt].Student_fees = Convert.ToDouble(textBox3.Text);
                stud[cnt].Addmission_date = textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();


                if (cnt == 10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("details of 10 student accepted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("student details are " + "\n");
            for (int i = 0; i < 10; i++)
            {
                sb.Append("Student RollNo : " + stud[i].Student_rollno + "\n");
                sb.Append("Student Name : " + stud[i].Student_name + "\n");
                sb.Append("Student Fees : " + stud[i].Student_fees + "\n");
                sb.Append("Admission Date : " + stud[i].Addmission_date + "\n");


            }
            label5.Text = sb.ToString();


            //code to find highest fees
            double high = stud[0].Student_fees;
            int foundat = 0;
            for (int i = 1; i < 10; i++)
            {
                if (high < stud[i].Student_fees)
                {
                    high = stud[i].Student_fees;
                    foundat = i;
                }
            }


            StringBuilder sb1 = new StringBuilder();
            sb1.Append("student with highest fees ");
            sb1.Append("student Roll no : " + stud[foundat].Student_rollno + "\n");
            sb1.Append("student name : " + stud[foundat].Student_name + "\n");
            sb1.Append("student fees : " + stud[foundat].Student_fees + "\n");
            sb1.Append("admission date : " + stud[foundat].Addmission_date + "\n");

            label6.Text = sb.ToString();
        }
    }
}
   
           
            
    


    

