﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bill_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount;
            double charge;
            double surcharge = 0,netamount;

            string name = textBox1.Text;
            int id = Convert.ToInt32(textBox2.Text);
            float unit = Convert.ToSingle(textBox3.Text);
            if(unit <199)
            {
              charge = 1.20;
            }
            else if(unit >=200 && unit <400)
            {
                charge = 1.50;
                 
            }
            else if(unit >=400 && unit<600)
            {
                charge = 1.80;
            }
            else
            {
                charge = 2.00;
            }
            amount = unit * charge;
            if(amount>400)
            {
                surcharge = amount * 15 / 100;
                netamount = amount + surcharge;
                label4.Text = "amount : " + amount;
                label5.Text = "surcharge : " + surcharge;
                label6.Text = "netamount : " + netamount;
            }
                



        }
    }
}
