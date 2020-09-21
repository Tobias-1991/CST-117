using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Zachary Gardner
//CST-117
//September 20, 2020
//Professor Pritchard
//This is my own work

namespace Inventory4Week7
{
    public partial class Form3 : Form
    {
        public Form3()
            
        {
            InitializeComponent();
        }

        InventoryManager IM = new InventoryManager();
        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            IM.AddNewItem(int.Parse(textBox1.Text), 
            textBox2.Text.ToString(), 
            int.Parse(textBox3.Text), 
            Double.Parse(textBox4.Text));

        }
    }
}
