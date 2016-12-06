using System.Linq;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ITTWEB_ASPNetCore.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public EmbeddedStockContext EmbeddedStockContext => Context as EmbeddedStockContext;

        public Category GetCategoryWithComponentTypes(int id)
        {
            return
                EmbeddedStockContext.Categories.Include(c => c.CategoryComponentTypes)
                    .ThenInclude(comp => comp.ComponentType)
                    .SingleOrDefault(c => c.CategoryId == id);
        }
    }
}