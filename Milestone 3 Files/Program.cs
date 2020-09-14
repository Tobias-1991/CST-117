using System;

namespace Milestone3Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            //create inventory items in array
            //I may use a list of arrays in the future.
            InventoryManager IM = new InventoryManager();
            Inventory[] Items = IM.CreateItemArray(100);

            Console.WriteLine("Welcome to the Kite Shop!  Press any key to see the menu");
            // Readkey pauses console until a key is pressed
            Console.ReadKey();
            // Clear removes all previous text from console
            Console.Clear();
            //reading and printing second object
           // for (int item = 0; item < Items.Length; item++)
            //{
                //Items[item].printInfo();
           // }
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Purchase a Butterfly Yoyo");
            Console.WriteLine("2) Purchase a Looping Yoyo");
            Console.WriteLine("3) Purchase a Kite");
            Console.WriteLine("4) Add New Item to Store");
            Console.WriteLine("5) Remove Item From Store");
            Console.WriteLine("6) Restock an Item");
            Console.WriteLine("7) Display all Items");
            Console.WriteLine("8) Search Inventory");
            Console.WriteLine("9) Exit");
            Console.Write("\r\nSelect an option: ");


            // Switch statement creates a great console menu
            // Each case is established, user input decides which option will be run.
            switch (Console.ReadLine())

            {
                case "1": // buy a butterfly yoyo
                    int totalPurchased = 0;
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string val = Console.ReadLine();
                    // string input must be converted to int datatype
                    totalPurchased = Convert.ToInt32(val);
                    // BuyItem method takes totalPurchased as parameter, and subtracts that number from 
                    // the saved inventory amount
                    Items[0].BuyItem(totalPurchased);
                    // Simple for loop prints inventory items
                    for (int item = 0; item < Items.Length; item++)
                    {
                        Items[item].printInfo();
                    }
                    return;
                case "2":// buy a looping yoyo

                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    val = Console.ReadLine();
                    totalPurchased = Convert.ToInt32(val);
                    Items[1].BuyItem(totalPurchased);
                    for (int item = 0; item < Items.Length; item++)
                    {
                        Items[item].printInfo();
                    }
                    return;
                case "3": //buy a kite
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    val = Console.ReadLine();
                    totalPurchased = Convert.ToInt32(val);
                    Items[2].BuyItem(totalPurchased);
                    for (int item = 0; item < Items.Length; item++)
                    {
                        Items[item].printInfo();
                    }
                    return;
                case "4": // Add a new item to the store
                    Console.Clear();
                    Console.WriteLine("What is the name of the new item?");
                    string itemName = Console.ReadLine();
                    Console.WriteLine("How many items are to be added to inventory?");
                    val = Console.ReadLine();
                    int numInStock = Convert.ToInt32(val);
                    Console.WriteLine("What is the price of the item?");
                    string price = Console.ReadLine();
                    double itemPrice = Convert.ToDouble(price);
                   // Items[0] = IM.AddNewItem(itemName, numInStock, itemPrice);
                    for (int item = 0; item < Items.Length; item++)
                    {
                    Items[item].printInfo();
                    }


                    return;
                case "5": // Remove an item from the store

                    Console.Clear();
                    Console.WriteLine("WHich item would you like to remove?");
                    val = Console.ReadLine();
                   
                    return;
                case "6":// Restock an item

                    Console.Clear();
                    Console.WriteLine("Which item would you like to restock?");
                    
                    return;
                case "7": //Display all items

                    Console.Clear();
                    Console.WriteLine("");
                    
                    return;
                case "8": // search inventory

                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    val = Console.ReadLine();
                    totalPurchased = Convert.ToInt32(val);
                    Items[1].BuyItem(totalPurchased);
                    for (int item = 0; item < Items.Length; item++)
                    {
                        Items[item].printInfo();
                    }
                    return;
                case "9": // Exit the application

                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    val = Console.ReadLine();
                    
                    return;
                default:

                    return;

            }
        }
    }
}
