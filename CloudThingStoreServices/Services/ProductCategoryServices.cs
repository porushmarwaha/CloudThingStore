using System.Collections.Generic;
namespace CloudThingStoreServices {
    public class ProductCategoryServices {
        private List<ProductCategory> _productCategories = new List<ProductCategory> ();
        private ProductCategory _category;
        private int count = 0;
        public ProductCategory Add (string name) {
            if (_productCategories.Exists (element => element.name == name.ToLower ())) 
                throw new CategoryNameAlreadyExistedException (name);

                _category = new ProductCategory { id = ++count, name = name.ToLower () };
                _productCategories.Add (_category);
                return _category;
        }
        public ProductCategory Update (int id, string name) {
            if (_productCategories.Exists (element => element.id == id))
                throw new CategoryIdNotExistedException (id);

            if (_productCategories.Exists (element => element.name == name.ToLower ()))
                throw new CategoryNameAlreadyExistedException (name);
                
            _category = _FindObjectById (id);
            _category.name = name.ToLower ();
            return _category;
        }
        public List<ProductCategory> Get () => _productCategories;
        public ProductCategory Get (int id) => _FindObjectById (id);
        public ProductCategory Get (string name) => _productCategories.Find (element => element.name == name.ToLower ());
        public bool Delete (int id) => _productCategories.Remove (_FindObjectById (id));
        private ProductCategory _FindObjectById (int id) => _productCategories.Find (element => element.id == id);
    }
}