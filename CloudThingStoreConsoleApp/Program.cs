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
                input = int.Parse (Console.ReadLine ());
                if (input == 1) {
                    Console.Write ($"\nPlease enter Category - ");
                    catgoryListService.Add(Console.ReadLine());
                    continue;
                }
                else if(input == 2){
                    Console.WriteLine("\nList of Category");
                    productCategory = catgoryListService.Get ();
                    productCategory.ForEach (element =>
                        Console.WriteLine ($"Id - {element.id}  Name - {element.name}"));
                    continue;                    
                }
                else if(input == 3){
                    Console.Write("\nPlease enter Id - ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Please enter new category Name - ");
                    name = Console.ReadLine();
                    catgoryListService.Update(id,name);
                    continue;
                }
                else if(input == 4){
                    Console.Write("\nPlease enter Id - ");
                    name = catgoryListService.Get(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"Name - {name}");
                    continue;
                }
                else break;
            }
            Console.WriteLine ("Thank you Visting");

        }
    }
}