using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userpassform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS01; integrated security=true;database=test1db"; 

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS01; integrated security=true;database=test1db";

            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "update users set upassword='" + textBox2.Text + "' where username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }


    }
}

