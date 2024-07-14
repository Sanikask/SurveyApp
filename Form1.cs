using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurevyApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;
            string name = textBox1.Text;
            string gender = comboBox1.Text;
            string age = textBox2.Text;
            string profession = comboBox2.Text;
            string highest_qualification = comboBox3.Text;
            string height = textBox3.Text;
            string weight = textBox4.Text;
            string sleep_hours = textBox5.Text;
            string screen_time = textBox6.Text;
            string exercise = comboBox4.Text;
            Class1 obj = new Class1();
           /* int no = obj.add_data(name, age, gender,  profession, highest_qualification,  height, weight,  sleep_hours, screen_time,  exercise);
            if (no > 0)
            {
                MessageBox.Show("Data added successfully");
            }
            else
            {
                MessageBox.Show("Data not added");
            }*/
            Page1 obj1 = new Page1(name, age, gender, profession, highest_qualification, height, weight, sleep_hours, screen_time, exercise,0);
            obj1.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
