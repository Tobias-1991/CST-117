/*
 * Zachary Gardner
 * CST-117
 * August 16, 2020
 * Professor Pritchard
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

            { 
            //Label 1 takes care of displaying the chosen model option using the listBox.SelectedItem method
            label1.Text = (string)("You have selected the \n ") + listBox1.SelectedItem;

            //Simple if, else if statements control the radio buttons 
            if (radioButton1.Checked == true)
            {
                label7.Text = (string)radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                label7.Text = (string)radioButton2.Text;
            }
            //Checkboxes are handled by simple console message and string with displayed option choice.
            if (checkBox1.Checked == true)
            {
                Console.WriteLine("You have selected the \n Limited Package!");
                label6.Text = (string)("You have selected the \n limited package!");
            }
            if (checkBox2.Checked == true)
            {
                Console.WriteLine("You have selected the \n optional offroad package!");
                label8.Text = (string)("You have selected the \n optional offroad package!");
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
