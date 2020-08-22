/*
 * Zachary Gardner
 * CST-117
 * August 21, 2020
 * Professor Pritchard
 * 
 * 
 * references: https://www.youtube.com/watch?v=uH4trBNn540
 * Code commented out is my original work before I looked into references
 * 
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

namespace Exercise5
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Declared global variables.
            double pi = 4;
            double denominator;
            string value = "";

            // label2.Text displays the number of terms along with an explanatory message
            label2.Text = "Approximate value of pi after " + textBox1.Text + " terms";

            // This for loop takes the integer input from textBox1, parses the integer value
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                
                denominator = i * 2 + 3;

                
                
                if (i % 2 == 0)
                {
                    // I created several console messages to help with debugging
                    // Console.WriteLine("This is pi so far " + pi);

                    // The first iteration is 4 - 1/3
                    pi -= 4 / denominator;
                    //Console.WriteLine("minus iteration " + denominator);

                } 
                else
                {
                    // Console.WriteLine("This is pi so far " + pi);
                    pi += 4 / denominator;
                    // Console.WriteLine("Positive iteration " + denominator);
                }

               //  Console.WriteLine("Another Test " + pi);

            }
            // Converted double pi value to a string
            value = pi.ToString();
            //display the results in label 3
            label3.Text = value;

            // Below this line is the code I worked on before I found a solution that worked.



            /*private void button1_Click(object sender, EventArgs e)
            {
            // fullTermList takes on the return value of the TermNumberList method
            List<int> fullTermList = new List<int>();

            fullTermList = TermNumberList(int.Parse(textBox1.Text));

            for (int test = 1; test < int.Parse(textBox1.Text); test++)
            {
                Console.WriteLine(4 - (4 / test) + 4 / (test + 2));
            }

            for (int terms = 1; terms < fullTermList.Count; terms++)
            {
                //Console.WriteLine(fullTermList[terms]);

              //  Console.WriteLine((4 - (4 / terms)) + (4 / (terms + 2)));
            }
        }
        private List<int> TermNumberList(int terms)
        {
            // int k stores the list of terms based on the given number of terms in textBox1
            // List<int> countingTermsList;

            // label2.Text displays the number of terms along with a explanatory message
            label2.Text = "Approximate value of pi after " + textBox1.Text + " terms";

            //int terms translates the string input to integer form
            // termList stores the resulting number of terms within a list
            List<int> termList = new List<int>();

            // this for loop adds each termFraction into the termList
            for (int termFraction = 1; termFraction < (int.Parse(textBox1.Text)); termFraction += 2)
            {
                termList.Add(termFraction);

            }
            // this for loop prints each term to console
             for (int i1 = 0; i1 < termList.Count; i1++)
             {
                 countingTermsList = termList[i1];
                 Console.WriteLine(countingTermsList);
             }
            return termList;
        */
        }
    }
}
