using System.Linq;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ITTWEB_ASPNetCore.Persistence.Repositories
{
    public class ComponentTypeRepository : Repository<ComponentType>, IComponentTypeRepository
    {
       
        public ComponentTypeRepository(DbContext context) : base(context)
        {
        }

        public EmbeddedStockContext EmbeddedStockContext  => Context as EmbeddedStockContext;

        public ComponentType GetComponentTypeWithComponents(int id)
        {
            return
                EmbeddedStockContext.ComponentTypes.AsNoTracking().Include(c => c.Components)
                    .SingleOrDefault(c => c.ComponentTypeId == id);
        }

        
    }
}