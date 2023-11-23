using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_customer_form_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w = 0;
        int d = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bank b = new bank();
            b.name = textBox1.Text;
            b.accountnumber = Convert.ToInt32(textBox2.Text);
            b.balance = Convert.ToInt32(textBox3.Text);
            b.deposite = Convert.ToInt32(textBox4.Text);
            b.withdrawl = Convert.ToInt32(textBox5.Text);

            d = b.balance + b.deposite;
            w = b.balance - b.withdrawl;

            StringBuilder sb = new StringBuilder();
            sb.Append("name : "+ b.name + "\n");
            sb.Append("account number : " + b.accountnumber + "\n");
            sb.Append("balance: " + b.balance + "\n");
            sb.Append("deposite: " + b.deposite + "\n");
            sb.Append("withdrawl : " + b.withdrawl + "\n");

            sb.Append("current balance after deposite: " + d + "\n");
            sb.Append("current balance after withdrawl: " + w + "\n");
            label6.Text = sb.ToString();
        }
    }
}
