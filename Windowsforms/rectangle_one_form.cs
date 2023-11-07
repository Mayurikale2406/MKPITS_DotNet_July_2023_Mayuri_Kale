using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectangle_one_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle();
            rec.width = Convert.ToInt32(textBox1.Text);
            rec.height = Convert.ToInt32(textBox2.Text);
            rec.area =rec. height +rec.width ;
            StringBuilder sb = new StringBuilder();
            sb.Append("area : " + rec.area);
            label2.Text = sb.ToString();
           
            
        }
    }
}
