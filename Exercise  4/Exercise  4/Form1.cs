using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise__4
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double seconds;
            double minutes;
            double hours;
            double days;

            seconds = double.Parse(textBox1.Text);
            minutes = seconds / 60;
            hours = seconds / 3600;
            days = seconds / 86400;

            if (seconds <= 59)
            {
                textBox2.Text = "Please enter value over 59";
            } else if (seconds >= 60 && seconds <=3599)
            {
                textBox2.Text = minutes.ToString() + " Minutes";
            } else if (seconds >= 3600 && seconds <= 85399)
            {
                textBox2.Text = hours.ToString() + " Hours";
            } else if (seconds >= 85399)
            {
                textBox2.Text = days.ToString() + " Days";
            }
                


        }
    }
}
