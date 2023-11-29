using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace form_student_attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Attendance> attendanceCollection = new Dictionary<int, Attendance>();
        Attendance att = null;
        private void button1_Click(object sender, EventArgs e)
        {
            att = new Attendance(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            attendanceCollection.Add(Convert.ToInt32(textBox1.Text), att);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
