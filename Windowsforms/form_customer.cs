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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace form_customer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, customer> cust = new Dictionary<int, customer>();
        private void button1_Click(object sender, EventArgs e)
        {

            customer c1 = new customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            customer c2 = new customer(Convert.ToInt32(textBox3.Text), textBox4.Text);
            cust.Add(c1.custid, c1);
            cust.Add(c2.custid, c2);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
               
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (KeyValuePair<int, customer> kv in cust)
                    {
                        sb.Append("cust id " + kv.Key + " customer name " + kv.Value.custname + "\n");
                    }
                    label5.Text = sb.ToString();
                }


            }

        }

       
    }
}
