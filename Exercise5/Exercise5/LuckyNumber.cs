using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class LuckyNumber : Form
    {
        
        public LuckyNumber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LuckyNumber_Load(object sender, EventArgs e)
        {
            FindYourLuckyNumber find = new FindYourLuckyNumber();
            //Console.WriteLine(find.finalResult.ToString());
           // Console.WriteLine(find.LuckyNumberResult().);
        }

       
    }
}
