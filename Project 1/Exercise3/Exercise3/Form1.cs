﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double pounds;
            double kgs;

            try
            {
                pounds = double.Parse(textBox1.Text);
                kgs = pounds * 0.453592;
                textBox2.Text = kgs.ToString();
            }

            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            Console.ReadLine();
        }            
        
    }
}


