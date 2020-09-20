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
    public partial class FindYourLuckyNumber : Form
    {
        
        public int numOne = 0;
        public int numTwo = 0;
        public int numThree = 0;
        public int finalResult = 0;
        public string SetValueForText2 = "";
        public int luckyNumberValue = 0;
        LuckyNumber Lucky = new LuckyNumber();

        public FindYourLuckyNumber()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            // color value 
            if (comboBox3.Text == "Red")
            {
                numTwo = 1;
            }
            else if (comboBox3.Text == "Yellow") 
            {
                numTwo = 2;
            }
            else if (comboBox3.Text == "Green") 
            {
                numTwo = 3;
            }
            else if (comboBox3.Text == "Blue") 
            {
                numTwo = 4;
            }
            else if (comboBox3.Text == "Orange") 
            {
                numTwo = 5;
            }
            else if (comboBox3.Text == "Purple")
            {
                numTwo = 6;
            }
            // Take Favorite animal value and convert to numbers
            if (comboBox4.Text == "Dog")
            {
                numThree = 5;
            } else if (comboBox4.Text == "Cat") {

                numThree = 10;
            } else if (comboBox4.Text == "Horse")
            {
                numThree = 15;
            } else if (comboBox4.Text == "Cow")
            {
                numThree = 20;
            } 
            // gather value from comboBox1
            numOne = int.Parse(comboBox1.SelectedItem.ToString());
            
            // times that result by num of letters in animal name

            //pass values to LuckyNumber form

           
            //do the math, and return result to be displayed in second form
            finalResult = LuckyNumberResult();
            Console.WriteLine("Your Lucky Number is " + finalResult);

            //Creates object Lucky in order to display second form
            Lucky.ShowDialog();
            
            
            


        }

        public int LuckyNumberResult() { 
      
            int FinalResult = numOne * numTwo + numThree;

            return FinalResult;
        }
    }
}
