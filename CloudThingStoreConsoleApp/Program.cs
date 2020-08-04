using System;
using System.Collections.Generic;
using CloudThingStoreServices;

namespace CloudThingStoreConsoleApp {
    class Program {
        static void Main (string[] args) {
            var catgoryListService = new ProductCategoryServices ();
            var productCategory = new List<ProductCategory> ();
            int input = 0;
            int id = 0;
            string name = "";
            while (true) {
                Console.WriteLine ("\n1. Add a Category \n2. Print List of All Category \n3. Update Category by Id \n4. Search Category by Id \n5. Exit");
                Console.Write ("Please Choose your Option - ");
                try {
                    input = int.Parse (Console.ReadLine ());
                } catch (Exception) {
                    Console.WriteLine ("Please give valid integer Input");
                    continue;
                }
                switch (input) {
                    case 1:
                        Console.Write ($"\nPlease enter Category - ");
                        catgoryListService.Add (Console.ReadLine ());
                        break;
                    case 2:
                        Console.WriteLine ("\nList of Category");
                        productCategory = catgoryListService.Get ();
                        if(productCategory.Count == 0){
                             Console.WriteLine("List is Empty");
                             break;
                        }
                        productCategory.ForEach (element =>
                            Console.WriteLine ($"Id - {element.id}  Name - {element.name}"));
                        break;
                    case 3:
                        Console.Write ("\nPlease enter Id - ");
                        id = int.Parse (Console.ReadLine ());
                        Console.Write ("Please enter new category Name - ");
                        name = Console.ReadLine ();
                        Console.WriteLine (catgoryListService.Update (id, name));
                        break;
                    case 4:
                        Console.Write ("\nPlease enter Id - ");
                        name = catgoryListService.Get (int.Parse (Console.ReadLine ()));
                        Console.WriteLine ($"Name - {name}");
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine ("Input not match from given List");
                        break;
                }
            }
        }
    }
}