using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ado.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "server=.\\SQLEXPRESS01; integrated security=true;database=test1db";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("connection succesfull");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = Databaseconnection.GetConnection();
            if(con != null)
            {
                MessageBox.Show("succesfull");
                con.Close();
            }
            else
            {
                MessageBox.Show("not connect");



















































































































































































































            }
        }
    }
}
