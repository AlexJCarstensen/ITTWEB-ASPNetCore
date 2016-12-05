using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Models;
using ITTWEB_ASPNetCore.Models.AccountViewModels;

namespace ITTWEB_ASPNetCore.ViewModels.ComponentViewModel
{
    public class ComponentViewModel
    {
        public Component Component { get; set; }
        public ComponentType ComponentType { get; set; }
        public int ComponentCount { get; set; }
    }
}
