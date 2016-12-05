using ITTWEB_ASPNetCore.Core.Domain;

namespace ITTWEB_ASPNetCore.Core.Repositories
{
    public interface IComponentTypeRepository : IRepository<ComponentType>
    {
        ComponentType GetComponentTypeWithComponents(int id);
    }
}