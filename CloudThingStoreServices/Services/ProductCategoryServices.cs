using System.Collections.Generic;
namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategories = new List<ProductCategory> ();
        private int count = 0;
        public ProductCategory Add (string categoryName) {
            if (!_productCategories.Exists (element => element.name == categoryName)){
                _productCategories.Add (new ProductCategory { id = ++count, name = categoryName });
                return _FindObjectByName(categoryName);
            }
            else throw new System.Exception ("category Name Already Existed");
        }
        public ProductCategory Update (int id, string name) {
                _FindObjectById (id).name = name;
                return _FindObjectById (id);
        }
        public List<ProductCategory> Get () {
            return _productCategories;
        }
        public ProductCategory Get (int id) {
            return _FindObjectById (id);
        }
        public ProductCategory Get (string name) {
            return _FindObjectByName (name);
        }
        public bool Delete (int id) {
            return _productCategories.Remove (_FindObjectById (id));
        }
        public bool Delete (string name) {
            return _productCategories.Remove (_FindObjectByName (name));
        }
        private ProductCategory _FindObjectById (int id) {
            return _productCategories.Find (element => element.id == id);
        }
        private ProductCategory _FindObjectByName (string name) {
            return _productCategories.Find (element => element.name == name);
        }
    }
}