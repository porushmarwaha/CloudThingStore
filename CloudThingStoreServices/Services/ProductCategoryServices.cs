using System;
using System.Collections.Generic;

namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategories;
        private int count;
        public ProductCategoryServices () {
            _productCategories = new List<ProductCategory> ();
            count = 0;
        }
        public void Add (string categoryName) {
            _productCategories.Add (new ProductCategory {
                id = ++count,
                    name = categoryName
            });
        }
        public List<ProductCategory> Get () {
            return _productCategories;
        }
        public string Get(int id){
            return _productCategories.Exists(element => 
                element.id == id) ? (_productCategories.Find(element => 
                    element.id == id)).name : "No Category ID Found";   
        }
        public string Update(int id , string name){
            if(_productCategories.Exists(element => element.id == id)){
                (_productCategories.Find(element => 
                    element.id == id)).name = name;
                    return "Successfully Updated";
            }
            return "ID not existed";
        } 
    }
}