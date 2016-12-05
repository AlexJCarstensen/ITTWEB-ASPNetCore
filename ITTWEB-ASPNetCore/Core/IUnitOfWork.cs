using System;

namespace ITTWEB_ASPNetCore.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();

    }
}