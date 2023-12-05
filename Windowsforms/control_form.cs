using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linklabel_control_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            label5.Text = "Selected name " + listBox1.SelectedItem.ToString();
            label5.Text = "age : " + numericUpDown1.Value.ToString();

        }
    }
}
