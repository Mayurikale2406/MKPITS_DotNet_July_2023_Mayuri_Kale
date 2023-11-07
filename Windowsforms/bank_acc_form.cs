using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_acc_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int balance = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            BankCustomer b1 = new BankCustomer();
            b1.name = textBox1.Text;
            
        }
    }
}
