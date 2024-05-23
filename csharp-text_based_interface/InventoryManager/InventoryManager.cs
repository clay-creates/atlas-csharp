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
            string[] tokens = input.Split(' ');

            switch (tokens[0])
            {
                case "classnames":
                    foreach (var ClassName in storage.objects.Keys)
                    {
                        Console.WriteLine(ClassName);
                    }
                    break;
                case 'all':
                    foreach (var obj in storage.objects.Values)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                    break;
                case "create" when tokens.Length == 3:
                    Type type = type.GetType(tokens[1]);
                    if (type != null)
                    {
                        var newObj = Activator.CreateInstance(type);
                        storage.New(newObj);
                        Console.WriteLine($"Objects of type: {type.Name} created.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid ClassName");
                    }
                case "show" when tokens.Length == 3:
                    Type type = type.GetType(tokens[1]);
                    if (type != null)
                    {

                    }
                case "update" when tokens.Length == 3:
                case "delete" when tokens.Length == 3:
                case "exit":
                    exitApp = true;
                    break;
                default:
                    Console.WriteLine($"Invalid Command.");
                    break;
            }
        }
    }
}