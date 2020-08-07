using System;
using System.Collections.Generic;
using CloudThingStoreServices;
namespace CloudThingStoreConsoleApp {
    public class ProductCategoryServiceFunctions {
        ProductCategoryServices catgoryListService = new ProductCategoryServices ();
        List<ProductCategory> productCategory = new List<ProductCategory> ();
        ProductCategory category;
        int id = 0;
        string name = "";
        internal void Add () {
            Console.Write ($"\nPlease enter Category - ");
            try {
                catgoryListService.Add (Console.ReadLine ());
            } catch (CategoryNameAlreadyExistedException e) {
                System.Console.WriteLine (e.Message);
            }
        }
        internal void Print () {
            Console.WriteLine ("\nList of Category");
            productCategory = catgoryListService.Get ();
            if (productCategory.Count == 0) {
                Console.WriteLine ("List is Empty");
                return;
            }
            productCategory.ForEach (element =>
                Console.WriteLine ($"Id - {element.id}  Name - {element.name}"));
        }
        internal void Update () {
            Console.Write ("\nPlease enter Id - ");
            try {
                id = int.Parse (Console.ReadLine ());
                Console.Write ("Please enter new category Name - ");
                name = Console.ReadLine ();
            } catch (FormatException e) {
                Console.WriteLine (e.Message);
            }
            try {
                catgoryListService.Update (id, name);
            } catch (CategoryIdNotExistedException e) {
                Console.WriteLine (e.Message);
            } catch (CategoryNameAlreadyExistedException e) {
                System.Console.WriteLine (e.Message);
            }
        }
        internal void Search () {
            Console.Write ("\nPlease enter Id or Name- ");
            name = Console.ReadLine();
            try {
                category = catgoryListService.Get (int.Parse (name));
            } catch {
                category = catgoryListService.Get (name);
            }
            catgoryListService.Get (Console.ReadLine ());
            Console.WriteLine ($"Id- {category.id} Name - {category.name}");
        }
        internal void Delete () {
            Console.Write ("\nPlease enter Id - ");
            try {
                if (catgoryListService.Delete (int.Parse (Console.ReadLine ())))
                    Console.WriteLine ($"Deleted Successfully");
                else Console.WriteLine ($"Id not existed");
            } catch (FormatException ex) {
                Console.WriteLine (ex.Message);
            }
        }
    }
}