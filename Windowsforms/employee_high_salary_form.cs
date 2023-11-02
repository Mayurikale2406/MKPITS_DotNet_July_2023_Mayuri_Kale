﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_high_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cnt < 3)
            {
                emp[cnt].EmployeeId = Convert.ToInt32(textBox1.Text);
                emp[cnt].Employee_Name = textBox2.Text;
                emp[cnt].Employee_salary = Convert.ToInt32(textBox3.Text);
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of 3 employee accepted ");
                }
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("employee details are : " + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("-------------------------------------\n");
                sb.Append("Employee Id : " + emp[i].EmployeeId + "\n");
                sb.Append("Employee Name : " + emp[i].Employee_Name + "\n");
                sb.Append("Employee Salary : " + emp[i].Employee_salary + "\n");
                sb.Append("-----------------------------------------\n");

                label4.Text = sb.ToString();
            }

            //code to find highest salary
            double high = emp[0].Employee_salary;
            int foundat = 0;
            for(int i=1;i<3;i++)
            {
              
                
                    if (high < emp[i].Employee_salary)
                    {
                        high = emp[i].Employee_salary;
                        foundat = i;
                    }
                   
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Employee with Highest Details ");
            sb1.Append("Employee Id : " + emp[foundat].EmployeeId + "\n");
            sb1.Append("Employee Name : " + emp[foundat].Employee_Name + "\n");
            sb1.Append("Employee Salary : " + emp[foundat].Employee_salary + "\n");

            label5.Text = sb1.ToString();
        }
    }
}
