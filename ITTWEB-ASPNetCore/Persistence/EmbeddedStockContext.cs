using ITTWEB_ASPNetCore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ITTWEB_ASPNetCore.Persistence
{
    public class EmbeddedStockContext : DbContext
    {
        public EmbeddedStockContext(DbContextOptions<EmbeddedStockContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<ESImage> EsImages { get; set; }
        public DbSet<CategoryComponentType> CategoryComponentTypes { get; set; }

    }
}