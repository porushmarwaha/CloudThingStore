using System;
namespace CloudThingStoreServices
{
    public class DuplicateCategoryException :Exception
    {
         public DuplicateCategoryException(string name) : base(name + " Already Existed") {

          }
    }
}