using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Zachary Gardner
CST-117
August 30, 2020
This is my own work
*/

namespace Milestone2
{
    class Inventory
    {
        // Properties for Inventory class
        private string itemName;
        private int numInStock;
        private double itemPrice;


        //Inventory Constructor
        public Inventory(string itemName, int numInStock, double itemPrice )
        {
            this.itemName = itemName;
            this.numInStock = numInStock;
            this.itemPrice = itemPrice;
        }
        //Getters and Setters
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value;  }
        }   
        public int NumInStock
        {
            get { return numInStock; }
            set { numInStock = value; }
        }

        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        public void SetInfo(string itemName, int numInStock, double itemPrice)
        {
            this.itemName = itemName;
            this.numInStock = numInStock;
            this.itemPrice = itemPrice;
        }

        // Buy item takes input and adjusts inventory amount after a purchase
        public void BuyItem(int numberPurchased)
        {
            numInStock = numInStock - numberPurchased;
        }

        // Prints complete inventory item list
        public void printInfo()
        {
            Console.WriteLine("Inventory Item: ");
            Console.WriteLine("\tName     : " + itemName);
            Console.WriteLine("\tNumber In Stock   : " + numInStock);
            Console.WriteLine("\tPrice      : " + itemPrice);
        }

        //Future methods to establish

        /* public void AddItem(int numInStock, string itemColor, double itemPrice)
         {
             Inventory newItemName = new Inventory(numInStock, itemColor, itemPrice);
         }*/
    }
}