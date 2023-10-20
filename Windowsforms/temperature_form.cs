using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(textBox1.Text);
            if(temp<=0)
            {
                label2.Text = "temperature is very cold";
            }
            else if(temp>0 && temp<10)
            {
                label2.Text = "temperature is cold";

            }
            else if(temp>10 && temp<30)
            {
                label2.Text = "temperature is normal";
            }
            else if(temp>=40)
            {
                label2.Text = "temperature is hot";
            }
        }
    }
}
