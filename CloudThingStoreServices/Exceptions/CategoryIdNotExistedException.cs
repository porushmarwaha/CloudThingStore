using System;
namespace CloudThingStoreServices
{
    public class CategoryIdNotExistedException : Exception
    {
        public CategoryIdNotExistedException(int id) : base(id + " - Id not Found") { 
        }
    }
}