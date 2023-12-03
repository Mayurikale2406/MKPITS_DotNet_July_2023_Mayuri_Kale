using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ename = (textBox1.Text);
            int sal = Convert.ToInt32(textBox2.Text);
        
            float hra = 0;
            float bonus = 0;
            
            if(comboBox1.Text == "Manager")
            {
                hra = sal * 0.35f;
                bonus = sal * 1000;

            }
            else if (comboBox1.Text=="clerk")
            {
                hra = sal * 0.25f;
                bonus = sal * 700;

            }
            else if (comboBox1.Text=="peon")
            {
                hra = sal * 0.15f;
                bonus = sal * 200;

            }

            float tsalary = hra + bonus;
            label4.Text = "hra " + hra;
            label5.Text = "bonus " + bonus;
            label6.Text = "total sal " + tsalary;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
