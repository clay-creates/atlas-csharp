using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using InventoryLibrary.JSONStorage;

class Program
{
    static void Main(string[] args)
    {
        JSONStorage storage = new JSONStorage();
        storage.Load();

        bool exitApp = false;
        while (!exitApp)
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");

            string input = Console.ReadLine().ToLowerInvariant();
            string[] parts = input.Split(' ');

            switch (parts[0])
            {
                case "classnames":
                    PrintClassNames(storage.All().Keys.Select)
            }
        }
    }
}