using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geomatrical_shape_num_form
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
            area = 3.14f * r * r;
            label3.Text = "result  : " + area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int side;
            int squ;
            
            side = Convert.ToInt32(textBox1.Text);
            squ = side*side;
            label3.Text = "result  : " + squ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rectangle;
            int l,w;

            l = Convert.ToInt32(textBox1.Text);
            w= Convert.ToInt32(textBox2.Text);
            rectangle = l*w;
            label3.Text = "result  : " + rectangle;
        }
    }
}
