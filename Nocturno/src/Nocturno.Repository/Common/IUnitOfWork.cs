using System;

namespace Nocturno.Data.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}