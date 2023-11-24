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
namespace sortlist_name_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList st = new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            st.Add(textBox1.Text, textBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = st.Keys;
            foreach(string st in key)
            {
                sb.Append("Movie name : " + st + "\n");
            }
            label3.Text = sb.ToString();

            ICollection val = st.Values;
            foreach(string st in val)
            {
                sb.Append("Actor name : " + st + "\n");
            }
            label4.Text = sb.ToString();
        }

        
    }
}
