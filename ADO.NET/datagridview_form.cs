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

namespace datagridview_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS01;integrated security = true;database=updb");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        private void button2_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from customer", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "cust");
            dataGridView1.DataSource = ds.Tables["cust"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["cust"]);
                MessageBox.Show("record updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
 }
