using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone3Week6
{
    class InventoryManager
    {

        public InventoryManager()
        {

        }
        public Inventory[] CreateItemArray(int size)
        {
            Inventory[] Items = new Inventory[size];
            return Items;             
        }
        //add new item
        public void AddNewItem(string itemName, int numInStock, double itemPrice)
        {
            Inventory Item = new Inventory(itemName, numInStock, itemPrice);

        }
        //remove existing item
        public void RemoveItem(string itemName)
        {

        }
        //restock item
        public void RestockItem(int itemsAdded)
        {

        }
        // display inventory items
        public void DisplayItems()
        {

        }
        //search for items by two criteria
        public void SearchItems(string itemName, double itemCost)
        {
            
        }
    }
}
