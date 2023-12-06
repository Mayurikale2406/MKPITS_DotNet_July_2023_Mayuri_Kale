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
    public partial class frmdebit : Form
    {
        public frmdebit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(numericUpDown1.Value);
            int bal = 0 ;
            bal = bal + amount;
            label4.Text = "bal " + bal;
            frmdebit f = new frmdebit();
            f.ShowDialog();

        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdebit d = new frmdebit();
            d.MdiParent = this;
            d.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = numericUpDown1.Value.ToString();
        }
    }
}
