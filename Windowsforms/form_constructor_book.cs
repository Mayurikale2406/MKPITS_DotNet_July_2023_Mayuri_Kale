using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form_constructor_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Book b = new Book(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
                StringBuilder sb = new StringBuilder();
                sb.Append("Book ID: " + b.bookid + "\n");
                sb.Append("Book Name: " + b.bookname + "\n");
                sb.Append("Book Author: " + b.bookauthor + "\n");

                label4.Text = sb.ToString(); 
            }




        }
    }
}


    
