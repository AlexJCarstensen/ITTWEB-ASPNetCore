using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ITTWEB_ASPNetCore.Persistence.Repositories
{
    public class ComponentRepository : Repository<Component>, IComponentRepository
    {
        public ComponentRepository(DbContext context) : base(context)
        {
        }

        public EmbeddedStockContext EmbeddedStockContext => Context as EmbeddedStockContext;

    }
}