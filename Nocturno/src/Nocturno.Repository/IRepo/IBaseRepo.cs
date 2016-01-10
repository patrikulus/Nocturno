using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.IRepo
{
    internal interface IBaseRepo<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        void SaveChanges();
    }
}