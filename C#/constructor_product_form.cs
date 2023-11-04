using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contructor_product_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product b = new product(textBox1.Text,Convert.ToInt32( textBox2.Text),Convert.ToInt32( textBox3.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Product Name: " + b.ProductName + "\n");
            sb.Append("Product Quantity: " + b.ProductQuantity + "\n");
            sb.Append("Product Price : " + b.ProductPrice + "\n");
            label4.Text = sb.ToString();

        }
    }
}
