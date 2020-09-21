using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory4Week7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new label1());

            InventoryManager IM = new InventoryManager();
            List<Inventory> itemList = new List<Inventory>();

            itemList.Add(new Inventory(001, "Blue Yoyo", 10, 5.99));

            IM.AddNewItem(002, "Red Yoyo", 10, 5.99);
            IM.AddNewItem(003, "Purple Yoyo", 10, 5.99);
            IM.AddNewItem(004, "Yellow Yoyo", 10, 5.99);
            IM.AddNewItem(005, "Black Yoyo", 10, 5.99);
            IM.AddNewItem(006, "Brown Yoyo", 10, 5.99);
            IM.AddNewItem(007, "White Yoyo", 10, 5.99);
            IM.AddNewItem(008, "Trick Yoyo", 10, 5.99);
            IM.AddNewItem(009, "Looping Yoyo", 10, 5.99);
            IM.AddNewItem(010, "Rainbow Yoyo", 10, 5.99);


            
        }
    }
}
