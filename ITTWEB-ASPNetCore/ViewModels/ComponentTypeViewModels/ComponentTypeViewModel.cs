using System.Collections.Generic;
using ITTWEB_ASPNetCore.Models.AccountViewModels;

namespace ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels
{
    public class ComponentTypeViewModel
    {
        public string Title { get; set; }
        public List<ComponentType> ComponentTypes { get; set; }

    }
}