using System;
using System.Collections.Generic;
using System.Text;

namespace Plan_Design
{
    class ListOfItems
    {
        public static void Items()
        {
            List<string> items = new List<string>();
            items.Add("Account Search");
            items.Add("Agency Search");
            items.Add("TPA Search");
            items.Add("Producer Search");
            items.Add("Vendor Search");
            items.Add("Facility");
            items.Add("OFAC Log Seach");
            items.Add("Document Search");
            items.Add("Upload Rollover File");
            items.Add("Upload Rollover");
            Console.WriteLine("Total Number of Items in Drop down are :" + items.Count);
            Console.WriteLine("List of drop down items are :");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
