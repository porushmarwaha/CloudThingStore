using System;
using System.Collections.Generic;
using CloudThingStoreServices;

namespace CloudThingStoreConsoleApp {
    class Program {
        static void Main (string[] args) {
            var catgoryListService = new ProductCategoryServices ();
            var productCategory = new List<ProductCategory> ();
            string counter;
            while (true) {
                Console.Write ($"PLease enter the Category  - ");
                catgoryListService.Add (Console.ReadLine ());
                Console.Write ("Do you Still want to Add Category yes or no ");
                counter = Console.ReadLine ();
                if (counter == "yes" || counter == "y" || counter == "Yes" || counter == "Y")
                    continue;
                break;
            }
            Console.WriteLine ();
            productCategory = catgoryListService.Get ();
            productCategory.ForEach (element =>
                Console.WriteLine ($"Id - {element.id}  Name - {element.name}"));

        }
    }
}