using System.Collections.Generic;

namespace ITTWEB_ASPNetCore.Models.AccountViewModels
{
    public class Category
    {
        public Category()
        {
            CategoryComponentTypes = new HashSet<CategoryComponentType>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryComponentType> CategoryComponentTypes { get;  set; } //TODO: Protected set when using database
    }

    public static class CategoryMock
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category() {CategoryId = 1, Name = "Category 1", CategoryComponentTypes = CategoryComponenttypeMock.GetCategoryComponentTypes(1)},
                new Category() {CategoryId = 2, Name = "Category 2", CategoryComponentTypes = CategoryComponenttypeMock.GetCategoryComponentTypes(2)},
                new Category() {CategoryId = 3, Name = "Category 3", CategoryComponentTypes = CategoryComponenttypeMock.GetCategoryComponentTypes(3)}
            };
        }
    }

    
}