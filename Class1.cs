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
    using System;
    using System.Collections.Generic;
    using System.Text;
        class Inventory
        {
            //Set all parameters for creating an inventory item
            public int itemID = 0;
            public string itemName = "";
            public int itemCount;
            public double itemPrice;

            //jConstructor for Inventory item
            public Inventory(int itemID, string itemName, int itemCount, double itemPrice)
            {
                this.itemID = itemID;
                this.itemName = itemName;
                this.itemCount = itemCount;
                this.itemPrice = itemPrice;
            }
            Inventory()
            {
            }
            //getters and setters
            int ItemID { get; set; }
            string ItemName { get; set; }
            int ItemCount { get; set; }
            double ItemPrice { get; set; }
        }
}
