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
        public ICollection<ComponentType> ComponentTypes { get; protected set; }
    }
}