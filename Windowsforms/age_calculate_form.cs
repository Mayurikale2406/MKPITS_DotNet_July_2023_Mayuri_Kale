using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_calculate_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("dob" + age);
            string yr = age.Substring(5);
            int yrr = dateTimePicker1.Value.Year;
            MessageBox.Show("Dob year : " + yrr);
            int cyr = DateTime.Now.Year;
            MessageBox.Show("current year : " + cyr);
            int diff = cyr - Convert.ToInt32(yrr);
            MessageBox.Show("your age : " + diff);
            label2.Text = " Calculated age : " + diff;
        }
    }
}
