using System;
using System.Collections.Generic;

namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategoriesObject;
        private List<String> _productCategoryName;
        private int count;
        public ProductCategoryServices () {
            _productCategoriesObject = new List<ProductCategory> ();
            count = 0;
        }
        public void Add (string categoryName) {
            _productCategoriesObject.Add (new ProductCategory {
                id = ++count,
                    name = categoryName
            });
        }
        public List<ProductCategory> Get () {
            return _productCategoriesObject;
        }
    }    
}