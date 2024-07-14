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
    public partial class Page10 : Form
    {
        int score;
        string name = "";
        string age = "";
        string gender = "";
        string profession = "";
        string highest_qualification = "";
        string height = "";
        string weight = "";
        string sleep_hours = "";
        string screen_time = "";
        string exercise = "";
        public Page10(string name, string age, string gender, string profession, string highest_qualification, string height, string weight, string sleep_hours, string screen_time, string exercise, int previous)
        {
            InitializeComponent();
            score = previous;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.profession = profession;
            this.highest_qualification = highest_qualification;
            this.height = height;
            this.weight = weight;
            this.sleep_hours = sleep_hours;
            this.screen_time = screen_time;
            this.exercise = exercise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                score = score + 0;
            }
            else if (radioButton2.Checked)
            {
                score = score + 1;
            }
            else if (radioButton3.Checked)
            {
                score = score + 2;
            }
            else if (radioButton4.Checked)
            {
                score = score + 3;
            }
            else if (radioButton5.Checked)
            {
                score = score + 4;

            }

           
              Class1 obj = new Class1();
               int no = obj.add_data(name, age, gender, profession, highest_qualification, height, weight, sleep_hours, screen_time, exercise, score);
               if (no > 0)
               {
                   MessageBox.Show("Data added successfully");
               }
               else
               {
                   MessageBox.Show("Data not added");
               }
        }
    }
}
