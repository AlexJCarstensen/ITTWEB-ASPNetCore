using ITTWEB_ASPNetCore.Core.Domain;

namespace ITTWEB_ASPNetCore.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryWithComponentTypes(int id);

    }
}