﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string u1 = textBox2.Text;
            string p1 = textBox3.Text;
            if(u1=="admin" && p1=="admin")
            {
                label4.Text = "login succenfully";

            }
            else 
            {
                label4.Text = "invalid passward ";
            }
        }
    }
}
