using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ragistration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(textBox1.Text + " ");
            sb.Append(textBox2.Text + "\n");

            sb.Append(textBox3.Text + "\n");
            sb.Append(textBox4.Text + "\n");

            string gender = null;

            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append ( "Gender : " + gender + "\n");
            sb.Append("country : " + comboBox1.Text + "\n");
            sb.Append("city : " + comboBox2.Text + "\n");
            sb.Append("DOB : " + dateTimePicker1.Text + "\n");
             MessageBox.Show("succesfully submit");
            label10.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text="";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Amravati");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Mumbai");
                    break;
                case "USA":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("Newyork");
                    comboBox2.Items.Add("LV");
                    break;

            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
           
        }
    }
}
