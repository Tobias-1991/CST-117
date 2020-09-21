using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Zachary Gardner
//CST-117
//September 20, 2020
//Professor Pritchard
//This is my own work
namespace Inventory4Week7
{
    class InventoryManager
    {
        //parameterless constructor for Inventory manager
        public InventoryManager()
        { }

        //created instance of inventory list
        public List<Inventory> items = new List<Inventory>();

        public void AddNewItem(int itemID, string itemName, int itemCount, double itemPrice)
        {
            items.Add(new Inventory(itemID, itemName, itemCount, itemPrice));
        }

        public void RemoveItem(int itemID)
        {
            items.RemoveAt(itemID);  
        }
        public void RestockItem(int itemID, int numAdded)
        {
             
        }
        public void DisplayItems()
        {

        }
       // public Inventory searchInventory(string SearchParam)
      //  {

         //   return Inventory;

       // }


           


    }
}
