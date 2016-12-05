using System.Collections.Generic;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Models;
using ITTWEB_ASPNetCore.Models.AccountViewModels;

namespace ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels
{
    public class ComponentTypeViewModel
    {
        public Category Category { get; set; }
        public List<ComponentType> ComponentTypes { get; set; }

        public ComponentType ComponentType { get; set; }

        public string SearchText { get; set; }

    }
}