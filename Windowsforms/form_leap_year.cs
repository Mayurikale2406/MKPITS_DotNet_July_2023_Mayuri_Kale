using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace leap_year_form
        {
            public partial class Form1 : Form
            {
                public Form1()
                {
                    InitializeComponent();
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    int year;
                    year = Convert.ToInt32(textBox1.Text);
                    if (year % 4 == 0)
                    {
                        Label2.Text = "it is leap year";
                    }
                    else
                    {
                        label2.Text = "it is not leap year";
                    }
                }
            }
        }


    }
}
    



    

