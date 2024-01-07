using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_user_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "server = .\\SQLEXPRESS01; integrated security= true; database=updb";
        SqlConnection con = null;
        SqlCommand cmd = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con = new SqlConnection(str);
                string qr = "select count (*) from users where username=@username and upassword=@upassword";
                SqlCommand cmd= new SqlCommand(qr, con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar,20).Value = textBox1.Text;
                cmd.Parameters.Add("@upassword", SqlDbType.VarChar, 20).Value = textBox2.Text;
                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if(cnt>0)
                {
                    label3.Text = "login succesfully";
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    label3.Text = "invalid credential";
                    
                }
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
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
