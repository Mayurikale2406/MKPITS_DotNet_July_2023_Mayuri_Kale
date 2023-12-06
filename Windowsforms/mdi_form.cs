using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            if (textBox1.Text=="mayuri" && textBox3.Text=="mayuri")
            {
                
                panel1.Visible = false;
                openNewAccountToolStripMenuItem.Enabled = true;
                depositeToolStripMenuItem.Enabled = true;
                openNewAccountToolStripMenuItem.Enabled = true;
                openToolStripMenuItem.Enabled = true;

                MessageBox.Show("succcesfully login");
              
            }
            else
            {
                MessageBox.Show("incorrect credencial ,try again");
            }
            frmaccount f = new frmaccount();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        
    }
}
