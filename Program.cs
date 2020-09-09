//Zachary Gardner
//CST-117
//September 9, 2020
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // path variable stores the path of the file
            string path = @"C:\Users\Zach\source\repos\Exercise10\Exercise10\testFile.txt";
            // count keeps track of instances of letters to be counted
            int count = 0;           

            //readText reads the text from the file.
            string readText = File.ReadAllText(path);

            //words reads each individual word into a string array
            string[] words = readText.Split(' ');

            string noPunctuation; 
            // for loop checks every word for the target letters
            for (int word = 0; word < words.Length; word++)
                {
                //removes punctuation from the string so the e, and t instances are counted correctly.
                noPunctuation = Regex.Replace(words[word], "[^A-Za-z0-9 ]", "");
                //test print shows each word in the console
                Console.WriteLine(noPunctuation);
                // If statement increments a counter for each instance of e, E, t, or T
                if (noPunctuation.EndsWith("e") || noPunctuation.EndsWith("t") || noPunctuation.EndsWith("T") || noPunctuation.EndsWith("E"))
                {
                    count++;
                    
                }                                      
            }
            Console.WriteLine("There are " + count + " words that end in e or t");
            
        }
    }
}
