using System.Collections.Generic;
namespace CloudThingStoreServices {
    public class ProductCategory {
        public int id { get; set; }
        public string name { get; set; }
        public List<ProductSubCategory> subCategory;
    }
}