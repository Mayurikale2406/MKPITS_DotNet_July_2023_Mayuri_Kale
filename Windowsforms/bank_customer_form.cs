using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_customer_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int balance = 0;
        int deposite;
        int withdrawl;

        

        private void button1_Click(object sender, EventArgs e)
        {

            Bank b1 = new Bank();
            b1.CustomerName = textBox1.Text;
            b1.AccountNumber = Convert.ToInt32(textBox2.Text);
            b1.amount = Convert.ToInt32(textBox3.Text);
            b1.Deposite = Convert.ToInt32(textBox4.Text);
            b1.Withdrawl = Convert.ToInt32(textBox5.Text);

            balance = balance + deposite;
            balance = balance - withdrawl;

            StringBuilder sb = new StringBuilder();
            sb.Append("customer name : " + b1.CustomerName);
            sb.Append("account number : " + b1.AccountNumber);
            sb.Append("amount : " + b1.amount);
            sb.Append("deposite : " + b1.Deposite);
            sb.Append("withdrawl : " + b1.Withdrawl);

            label6.Text = sb.ToString();


        }
    }
}
