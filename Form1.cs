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
    public partial class label1 : Form
    {
        public label1()
        {
            InitializeComponent();
        }
        InventoryManager IM = new InventoryManager();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IM.AddNewItem(001, "Yoyo", 10, 10.99);
            IM.AddNewItem(002, "Kite", 10, 12.99);

            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.BeginUpdate();


            listBox1.DisplayMember = "001 Yoyo 10 10.99";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void label1_Load(object sender, EventArgs e)
        {

        }
    }
}
