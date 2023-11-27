using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace form_linked_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<int> l = new LinkedList<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            l.AddLast(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.AddFirst(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
           
            {
                StringBuilder sb = new StringBuilder();
                foreach (int i in l)
                {
                    sb.Append("num : " + i + "\n");
                }
                label3.Text = sb.ToString();
            }

        }
    }
}
