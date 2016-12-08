using System;
using ITTWEB_ASPNetCore.Core.Repositories;

namespace ITTWEB_ASPNetCore.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        ICategoryRepository Categories { get; }
        IComponentTypeRepository ComponentTypes { get; }

        IComponentRepository Components { get; }

        ICategoryComponentTypeRepository CategoryComponentTypes { get; }

    }
}