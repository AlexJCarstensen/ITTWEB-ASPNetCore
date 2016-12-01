using System.Collections.Generic;

namespace ITTWEB_ASPNetCore.Models.AccountViewModels
{
    public class Category
    {
        public Category()
        {
            ComponentTypes = new HashSet<ComponentType>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<ComponentType> ComponentTypes { get;  set; } //TODO: Protected set when using database
    }

    public static class CategoryMock
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category() {CategoryId = 1, Name = "Category 1", ComponentTypes = ComponentTypeMock.GetComponentTypes()},
                new Category() {CategoryId = 2, Name = "Category 2", ComponentTypes = ComponentTypeMock.GetComponentTypes()},
                new Category() {CategoryId = 3, Name = "Category 3", ComponentTypes = ComponentTypeMock.GetComponentTypes()}
            };
        }
    }

    
}