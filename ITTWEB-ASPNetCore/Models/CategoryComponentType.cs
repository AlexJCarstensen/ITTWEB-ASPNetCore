using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Models;

namespace ITTWEB_ASPNetCore.Models
{
    public class CategoryComponentType
    {
        public int CategoryComponentTypeId { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public long ComponentTypeId { get; set; }
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
