using System.Collections.Generic;
namespace CloudThingStoreServices
{
    public class SubCategoryService
    {
        
        public ProductCategoryServices categoryListService = new ProductCategoryServices();
        public ProductCategory category = new ProductCategory();  
        public ProductSubCategory subCategory = new ProductSubCategory();
        private int _count = 0;

        public ProductSubCategory Add(int id , string name){
            category = categoryListService.Get(id);
            subCategory = new ProductSubCategory { id = ++_count, name = name.ToLower()};
            category.subCategories.Add(subCategory);
            return subCategory;
        }
 
    }
}