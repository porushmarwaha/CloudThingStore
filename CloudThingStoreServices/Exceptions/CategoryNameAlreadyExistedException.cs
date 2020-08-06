using System;
namespace CloudThingStoreServices
{
    public class CategoryNameAlreadyExistedException :Exception
    {
         public CategoryNameAlreadyExistedException(string name) : base(name + "Already Existed") {

          }
    }
}