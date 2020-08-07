using System;
namespace CloudThingStoreServices
{
    public class CategoryNotExistException : Exception
    {
        public CategoryNotExistException(int id) : base(id + " - Id not Found") { 
        }
    }
}