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
namespace queue_class_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue qu = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            qu.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(string st in qu)
            {
                sb.Append(st + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();

            qu.Dequeue();
            foreach(string st in qu)
            {
                sb1.Append(st + "\n");
            }
            label3.Text = sb1.ToString();
        }
    }
}
