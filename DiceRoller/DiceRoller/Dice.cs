using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading;
namespace DiceRoller
{
    // Create Dice class with 
    // variables "sides" and "faceValue"
    class Dice
    {
        private int sides;
        private int faceValue;

        public Dice(int sides)
        {
            this.sides = sides;
            SidesValidation(sides);
        }

        // RollDie method returns the face value of rolled die
        public int RollDie()
        {
            Random Random = new Random();

            faceValue = Random.Next(1, sides);

            return faceValue;
        }

        // Sides Validation method 
        public void SidesValidation(int sides)
        {
            if (sides < 4 || sides > 20)
            {
                Console.WriteLine("You entered: " + sides + " Please enter number between 4 and 20.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
