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

namespace arraylist_insert_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arr = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capacity : " + arr.Capacity);
            MessageBox.Show("count : " + arr.Count);
            StringBuilder sb = new StringBuilder();
            foreach (object ob in arr)

            {
                sb.Append("student name : " + ob.ToString() + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.Insert(3,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}
