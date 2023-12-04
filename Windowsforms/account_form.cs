using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace account_form_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            if (checkBox1.Checked)
            {
                bal = bal + amt;
            }
            else if (checkBox2.Checked)
            {
                bal = bal - amt;
            }
            label3.Text = "bal is " + bal;


        }
    }
}
