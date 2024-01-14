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
namespace student_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Studeclassnt s = new Studeclassnt();
            string ss = null;
            if(radioButton1.Checked)
            {
                ss = "Male";

            }
            if(radioButton2.Checked)
            {
                ss = "Female";
            }
            string h = null;
            if(checkBox1.Checked)
            {
                h = "Reading";
            }
            if(checkBox2.Checked)
            {
                if (h != null)
                    h = h + "" + "Dancing";
                else
                    h = "Dancing";
                   
            }
            if(checkBox3.Checked)
            {
                if (h != null)
                    h = h + "" + h + "" + "Talking";
                else
                    h = "Talking";
            }
            string result = s.Insertstudent(Convert.ToInt32(textBox1.Text), textBox2.Text, ss, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            clearText();

        }
        public void clearText()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Studeclassnt s = new Studeclassnt();
            string ss = null;
            if (radioButton1.Checked)
            {
                ss = "Male";

            }
            if (radioButton2.Checked)
            {
                ss = "Female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "Reading";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                    h = h + "" + "Dancing";
                else if (h != null)
                    h = h + "" + "Talking";
            }
      

            string result = s.updatestudent(Convert.ToInt32(textBox1.Text), textBox2.Text, ss, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());

            label7.Text = result;
            clearText();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Studeclassnt s = new Studeclassnt();
            string result = s.deletestudent(Convert.ToInt32(textBox1.Text), textBox2.Text);

            label7.Text = result;
            clearText();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Studeclassnt s = new Studeclassnt();
            SqlDataReader dr = s.SearchStudent(Convert.ToInt32(textBox1.Text));
            while(dr.Read())
            {
                textBox2.Text = dr["studname"].ToString();
            }
            dr.Close();
        }
    }
}

