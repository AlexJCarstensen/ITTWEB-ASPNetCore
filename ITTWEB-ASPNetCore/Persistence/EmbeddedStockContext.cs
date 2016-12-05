using ITTWEB_ASPNetCore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ITTWEB_ASPNetCore.Persistence
{
    public class EmbeddedStockContext : DbContext
    {
        private readonly IConfigurationRoot _config;
        public EmbeddedStockContext(IConfigurationRoot config) : base()
        {
            _config = config;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<ESImage> EsImages { get; set; }
        public DbSet<CategoryComponentType> CategoryComponentTypes { get; set; }

    }
}