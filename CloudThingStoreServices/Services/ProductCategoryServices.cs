using System;
using System.Collections.Generic;

namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategoriesObject;
        private List<String> _productCategoryName;
        private int _count = 0;
        public void Add (string categoryName) {
            _productCategoriesObject.Add (new ProductCategory () {
                id = ++_count,
                    name = categoryName
            });
        }
        public List<String> Get () {
            _productCategoryName = new List<string> ();
            _productCategoriesObject.ForEach (
                element => _productCategoryName.Add (element.name));
            return _productCategoryName;
        }
    }
}