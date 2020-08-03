﻿using System;
using System.Collections.Generic;
using CloudThingStoreServices;

namespace CloudThingStoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<String> productCategoryNames;
            var catgoryListServicesObject =  new ProductCategoryServices(); 
            catgoryListServicesObject.Add("Rahul");
            catgoryListServicesObject.Add("Vikram");
            catgoryListServicesObject.Add("Vinod");
            catgoryListServicesObject.Add("Vishal");
            catgoryListServicesObject.Add("Vishesh");
            catgoryListServicesObject.Add("Vikral");
            catgoryListServicesObject.Add("Vishnu");
            
            productCategoryNames = catgoryListServicesObject.Get();
            
            productCategoryNames.ForEach(
                element => Console.WriteLine(element));            
        }
    }
}
