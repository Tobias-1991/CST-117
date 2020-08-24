/*
Zachary Gardner
CST-117
Professor Pritchard
August 23, 2020d
 */
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *Write a windows form application that does the following:
Uses a file dialog control to allow the user to select a file for input
Processes the contents of the file as follows:
Converts all the words to lower-case
Finds the first and last word alphabetically
Finds the longest word
Finds the word with the most vowels
Displays the above statistics in a textbox
Writes the above statistics to a file 
 */
namespace Project3_Files
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string[] words;
            string longestWord = "";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|Word docs (*.docx)|*.docx|Rich Text (*.rtf)|*.rtf";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = fileDialog.FileName;

                var fileStream = fileDialog.OpenFile();

                string[] delimiter = new string[] {" ", "\r\n", ",", ".", "(", ")"};
                using (StreamReader reader = new StreamReader(fileStream))
                {

                    fileContent = reader.ReadToEnd();
                }
                //Converts all the words to lower-case
                string fileString = fileContent.ToString().ToLower();

                // Finds the first and last word alphabetically
                words = fileString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                // Sorts words alphabetically
                Array.Sort(words);

                //Finds the longest word
                for (int word = 0; word < words.Length; word++)
                {
                    if (words[word].ToString().Length > longestWord.Length)
                    {
                        longestWord = words[word];
                    }
                }

                //Finds the word with the most vowels
              
               
             /*   var mostVowels = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    var part = words[i];
                    var numberOfVowels = 0;
                    foreach (var vowel in vowels)
                    {
                        if (part.Contains(vowel)) numberOfVowels++;
                    }

                    if (mostVowels < numberOfVowels)
                    {
                        mostVowels = i;
                        word = part;
                    }
                }*/

                richTextBox1.Text = fileContent.ToString() + "\r\n" + "\r\n" + fileString + "\r\n" + 
                    "\r\n" + words[0] + "\r\n" + "\r\n" +  words[words.Length-1] + "\r\n" + "\r\n" + 
                    "The Longest word is " + longestWord + "\r\n" + "\r\n";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|Word docs (*.docx)|*.docx|Rich Text (*.rtf)|*.rtf";
            saveDialog.Title = "Save a text file";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveDialog.OpenFile();
            }
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveDialog.OpenFile()) != null) ;

            }

        }


        /* 
         * 
         * 
         *   Stream myStream;
             SaveFileDialog saveDialog = new SaveFileDialog();
             saveDialog.Filter = "txt files (*.txt)|*.txt|Word docs (*.docx)|*.docx|Rich Text (*.rtf)|*.rtf";
             saveDialog.Title = "Save a text file";
             saveDialog.FilterIndex = 2;
             saveDialog.RestoreDirectory = true;

             if (saveDialog.FileName != "")
             {
                 System.IO.FileStream fs = (System.IO.FileStream)saveDialog.OpenFile();
             }
             if (saveDialog.ShowDialog() == DialogResult.OK)
             {
                 if ((myStream = saveDialog.OpenFile()) != null);   
             }
 
         * OpenFileDialog fileDialog = new OpenFileDialog();
         fileDialog.Filter = "txt files (*.txt)|*.txt|Word docs (*.docx)|*.docx|Rich Text (*.rtf)|*.rtf";

             if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 filePath = fileDialog.FileName;

                 var fileStream = fileDialog.OpenFile();

         string[] delimiter = new string[] { " ", "\r\n", ",", ".", "(", ")" };
                 using (StreamReader reader = new StreamReader(fileStream))
                 {

                     fileContent = reader.ReadToEnd();
                 } */

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
