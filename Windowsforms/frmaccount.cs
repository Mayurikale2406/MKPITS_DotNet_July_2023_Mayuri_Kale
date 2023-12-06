using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mdi_form
{
    public partial class frmaccount : Form
    {
        public frmaccount()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaccount a = new frmaccount();
            a.MdiParent = this;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Email :  " + textBox1.Text + "\n");
            sb.Append("password :  " + textBox2.Text + "\n");
            sb.Append("Name : " + textBox3.Text + "\n");
            sb.Append("Address : " + textBox4.Text + "\n");
            sb.Append("contact number : " + maskedTextBox1.Text + "\n");
            sb.Append("Age : " + numericUpDown1.Text + "\n");
            sb.Append("Occupation : " + comboBox1.Text + "\n");
            sb.Append("Annual Income : " + textBox5.Text + "\n");

            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("gender :" + gender + "\n");

            label10.Text = sb.ToString();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label10.Text = maskedTextBox1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = numericUpDown1.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
            switch (comboBox1.Text)
            {
                case "Service":
                    comboBox1.Items.Add("");
                  
                    break;
                case "Business":
            
                    comboBox1.Items.Add("");
                  
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            numericUpDown1.Value = 0;
            
        }
    }
}
