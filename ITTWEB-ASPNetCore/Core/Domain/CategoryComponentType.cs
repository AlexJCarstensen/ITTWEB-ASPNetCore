using System.Collections.Generic;
using ITTWEB_ASPNetCore.Models;

namespace ITTWEB_ASPNetCore.Core.Domain
{
    public class CategoryComponentType
    {
        public int CategoryComponentTypeId { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
    }

    public static class CategoryComponenttypeMock
    {
        public static List<CategoryComponentType> GetCategoryComponentTypes(int categoryId)
        {
            return new List<CategoryComponentType>
            {
                new CategoryComponentType()
                {
                    CategoryId = categoryId,
                    ComponentType = ComponentTypeMock.GetComponentType(categoryId),
                    ComponentTypeId = categoryId
                },
                new CategoryComponentType()
                {
                    CategoryId = categoryId,
                    ComponentType = ComponentTypeMock.GetComponentType(categoryId + 1),
                    ComponentTypeId = categoryId
                },
                new CategoryComponentType()
                {
                    CategoryId = categoryId,
                    ComponentType = ComponentTypeMock.GetComponentType(categoryId + 2),
                    ComponentTypeId = categoryId
                }

            };
        } 
    }
}
