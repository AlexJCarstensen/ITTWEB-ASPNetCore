using System.Collections.Generic;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Models;
using ITTWEB_ASPNetCore.Models.AccountViewModels;

namespace ITTWEB_ASPNetCore.ViewModels.CategoryViewModels
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}