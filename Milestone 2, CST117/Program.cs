using Milestone2;
using System;

/*
 Zachary Gardner
CST-117
August 30, 2020
This is my own work
 */

namespace MilestoneProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //create inventory items in array
            //I may use a list of arrays in the future.
            Inventory[] Item = new Inventory[3];
            Item[0] = new Inventory("Butterly Yoyo", 10, 14.99);
            Item[1] = new Inventory("Looping Yoyo", 10, 10.99);
            Item[2] = new Inventory("Kite", 10, 24.99);

       
            Console.WriteLine("Welcome to the Kite Shop!  Press any key to see inventory");
            // Readkey pauses console until a key is pressed
            Console.ReadKey();
            // Clear removes all previous text from console
            Console.Clear();
            //reading and printing second object
            for (int items = 0; items < Item.Length; items++)
            {
                Item[items].printInfo();
            }
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Purchase a Butterfly Yoyo");
            Console.WriteLine("2) Purchase a Looping Yoyo");
            Console.WriteLine("3) Purchase a Kite");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");


            // Switch statement creates a great console menu
            // Each case is established, user input decides which option will be run.
            switch (Console.ReadLine())

            {
                case "1":
                    int totalPurchased = 0;
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string val = Console.ReadLine();
                    // string input must be converted to int datatype
                    totalPurchased = Convert.ToInt32(val);
                    // BuyItem method takes totalPurchased as parameter, and subtracts that number from 
                    // the saved inventory amount
                    Item[0].BuyItem(totalPurchased);
                    // Simple for loop prints inventory items
                    for (int items = 0; items < Item.Length; items++)
                    {
                        Item[items].printInfo();
                    }
                    return;
                case "2":

                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    val = Console.ReadLine();
                    totalPurchased = Convert.ToInt32(val);
                    Item[1].BuyItem(totalPurchased);
                    for (int items = 0; items < Item.Length; items++)
                    {
                        Item[items].printInfo();
                    }
                    return;
                case "3":
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    val = Console.ReadLine();
                    totalPurchased = Convert.ToInt32(val);
                    Item[2].BuyItem(totalPurchased);
                    for (int items = 0; items < Item.Length; items++)
                    {
                        Item[items].printInfo();
                    }
                    return;
                default:
                  
                    return;

            }       
        }    
    }
}
