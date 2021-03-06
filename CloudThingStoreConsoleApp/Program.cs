﻿using System;
using System.Collections.Generic;
using CloudThingStoreServices;
namespace CloudThingStoreConsoleApp {
    class Program {
        static void Main (string[] args) {
            var catgoryListService = new ProductCategoryServices ();
            var productCategory = new List<ProductCategory> ();
            ProductCategory category;
            int input = 0;
            int id = 0;
            string name = "";
            while (true) {
                Console.WriteLine ("\n1. Add a Category \n2. Print List of All Category \n3. Update Category by Id \n4. Search Category by Id or Name \n5. Delete Category by Id or Name\n6. Exit");
                Console.Write ("Please Choose your Option - ");
                try {
                    input = int.Parse (Console.ReadLine ());
                } catch (Exception) {
                    Console.WriteLine ("Please give valid integer Input");
                    continue;
                }
                switch (input) {
                    case 1:
                        // Add Method
                        Console.Write ($"\nPlease enter Category - ");
                        catgoryListService.Add (Console.ReadLine ());
                        break;
                    case 2:
                        // Print Method
                        Console.WriteLine ("\nList of Category");
                        productCategory = catgoryListService.Get ();
                        if (productCategory.Count == 0) {
                            Console.WriteLine ("List is Empty");
                            break;
                        }
                        productCategory.ForEach (element =>
                            Console.WriteLine ($"Id - {element.id}  Name - {element.name}"));
                        break;
                    case 3:
                        // Update Method
                        Console.Write ("\nPlease enter Id - ");
                        id = int.Parse (Console.ReadLine ());
                        Console.Write ("Please enter new category Name - ");
                        name = Console.ReadLine ();
                        Console.WriteLine ($"ID - {catgoryListService.Update (id, name).id} is Successfully Updated");
                        break;
                    case 4:
                        // Search Method
                        Console.Write ("\nPlease enter Id or Name- ");
                        category = catgoryListService.Get (int.Parse (Console.ReadLine ()));
                        Console.WriteLine ($"Id- {category.id} Name - {category.name}");
                        break;
                    case 5:
                        //Delete Method
                        Console.Write ("\nPlease enter Id or Name- ");
                        if (catgoryListService.Delete (int.Parse (Console.ReadLine ())))
                            Console.WriteLine ($"Deleted Successfully");
                        break;
                    case 6:
                        // Exit Method
                        System.Environment.Exit (0);
                        break;
                    default:
                        Console.WriteLine ("Input not match from given List Options");
                        break;
                }
            }
        }
    }
}