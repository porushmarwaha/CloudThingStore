using System;
using System.Collections.Generic;

namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategories;
        private ProductCategory _category;
        private int count;
        public ProductCategoryServices () {
            _productCategories = new List<ProductCategory> ();
            //  _category = new ProductCategory();
            count = 0;
        }
        // Return Empty Object
        public ProductCategory Add (string categoryName) {
            if (!_CheckExistedObjectByName (categoryName)) {
                _productCategories.Add (new ProductCategory {
                    id = ++count,
                        name = categoryName
                });
                return _FindObjectByName (categoryName);
            }
            return _category;

        }
        public List<ProductCategory> Get () {
            return _productCategories;
        }
        // throw method
        public ProductCategory Get (int id) {
            if (_CheckExistedObjectById (id))
                return _FindObjectById (id);
            else throw new ArgumentException ();
        }
        public ProductCategory Get (string name) {
            if (_CheckExistedObjectByName (name)) return _FindObjectByName (name);
            else throw new ArgumentException ();
        }
        public ProductCategory Update (int id, string name) {
            if (_CheckExistedObjectById (id)) {
                _FindObjectById (id).name = name;
                return _FindObjectById (id);
            } else throw new ArgumentException ();
        }
        public bool Delete (int id) {
            if (_CheckExistedObjectById (id)) {
                _productCategories.Remove (_FindObjectById (id));
                return true;
            } else throw new ArgumentException ();

        }
        public bool Delete (string name) {
            if (_CheckExistedObjectByName (name)) {
                _productCategories.Remove (_FindObjectByName (name));
                return true;
            } else throw new ArgumentException ();
        }

        private ProductCategory _FindObjectById (int id) {
            return _productCategories.Find (element => element.id == id);
        }
        private ProductCategory _FindObjectByName (string name) {
            return _productCategories.Find (element => element.name == name);
        }
        private bool _CheckExistedObjectById (int id) {
            return _productCategories.Exists (element => element.id == id);
        }
        private bool _CheckExistedObjectByName (string name) {
            return _productCategories.Exists (element => element.name == name);
        }
    }
}