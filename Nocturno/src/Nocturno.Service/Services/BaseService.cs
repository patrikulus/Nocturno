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

        public void Create(TEntity entity)
        {
            _db.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _db.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public TEntity GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}