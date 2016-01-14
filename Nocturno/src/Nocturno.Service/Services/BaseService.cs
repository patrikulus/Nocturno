using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Extensions;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;

namespace Nocturno.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IDbContext _db;

        public BaseService(IDbContext db)
        {
            _db = db;
        }

        public virtual void Create(TEntity entity)
        {
            _db.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _db.Remove(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>();
        }

        public virtual TEntity GetById(int? id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public virtual TEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public virtual void Commit()
        {
            _db.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _db.Update(entity);
        }
    }
}