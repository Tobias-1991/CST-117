using System;
using System.Data;
using System.Threading;
namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int diceSides = 0;
            int die1Roll = 0;
            int die2Roll = 0;
            int numRolls = 0;
            bool snakeEyes = false;

            try
            {

                Console.WriteLine("Welcome to Dice Roller!");
                Console.WriteLine("Enter a positive integer between 4 and 20");
                //take user input for number of dice sides
                userInput = Console.ReadLine();
                //convert to integer type
                diceSides = Convert.ToInt32(userInput);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Dice die1 = new Dice(diceSides);
            Dice die2 = new Dice(diceSides);
            Console.WriteLine("Your " + diceSides + " sided dice are ready! Press any key to roll them");
            Console.ReadKey(true);

            do
            {
                die1Roll = die1.RollDie();
                Console.WriteLine("Die 1 Rolled " + die1Roll);
                die2Roll = die2.RollDie();
                Console.WriteLine("Die 2 Rolled " + die2Roll);
                numRolls++;
                Console.WriteLine("You have rolled " + numRolls + " times.");

                if (die1Roll == 1 && die2Roll == 1)
                {
                    snakeEyes = true;
                    Console.WriteLine("Congrats! You rolled snake eyes in " + numRolls + " Rolls");
                    Thread.Sleep(10000);
                    Environment.Exit(0);
                }
            } while (snakeEyes == false);
        }
    }
}
