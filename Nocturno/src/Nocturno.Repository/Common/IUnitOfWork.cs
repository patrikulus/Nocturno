using System;

namespace Nocturno.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}