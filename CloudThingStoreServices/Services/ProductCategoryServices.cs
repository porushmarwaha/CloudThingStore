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
            if (_CheckExistedObjectByName (categoryName))
                _productCategories.Add (new ProductCategory {
                    id = ++count,
                        name = categoryName
                });
            else throw new ArgumentException ("Element Already exists in list");

        }
        public List<ProductCategory> Get () {
            return _productCategories;
        }
        public ProductCategory Get (int id) {
            // if (_CheckExistedObjectById (id))
            try {
                return _FindObjectById (id);
            } catch (ArgumentException) {
                throw new ArgumentException ("Id not Found");
            }
        }
        public ProductCategory Get (string name) {
            if (_CheckExistedObjectByName (name)) return _FindObjectByName (name);
            else throw new ArgumentException ("Name not Found");
        }
        public ProductCategory Update (int id, string name) {
            if (_CheckExistedObjectById (id)) {
                _FindObjectById (id).name = name;
                return _FindObjectById (id);
            } else throw new ArgumentException ("Id not Found");
        }
        public bool Delete (int id) {
            if (_CheckExistedObjectById (id)) {
                _productCategories.Remove (_FindObjectById (id));
                return true;
            } else throw new ArgumentException ("Id not Found");

        }
        public bool Delete (string name) {
            if (_CheckExistedObjectByName (name)) {
                _productCategories.Remove (_FindObjectByName (name));
                return true;
            } else throw new ArgumentException ("Name not Found");
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