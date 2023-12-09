using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hscrollbar_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            this.Width = hScrollBar1.Value;
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            this.Height = vScrollBar1.Value;
        }
    }
}
