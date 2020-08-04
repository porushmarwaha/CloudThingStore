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
            return _productCategories[id -1].name;  
        }
        public void Update(int id , string name){
            _productCategories[id - 1].name = name;
        } 
    }
}