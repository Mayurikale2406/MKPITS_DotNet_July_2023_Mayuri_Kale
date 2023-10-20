using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            float area;
            r = Convert.ToInt32(textBox1.Text);
            area=3.14f * r * r;
            label2.Text = "result : " + area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r;
            float circ;
            r = Convert.ToInt32(textBox1.Text);
            circ = 2 * 3.14f * r ;
            label2.Text = "result : " + circ;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
