using Microsoft.Data.Entity;
using Nocturno.Repository.Context;
using Nocturno.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.Repo
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : class
    {
        private readonly NocturnoContext _db;

        public BaseRepo(NocturnoContext db)
        {
            _db = db;
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
        }

        public void DeleteById(int id)
        {
            Remove(GetById(id));
        }

        public IQueryable<TEntity> GetAll()
        {
            return _db.Set<TEntity>().AsQueryable();
        }

        public TEntity GetById(int id)
        {
            //return _db.Set<TEntity>().Find(id);
            return null;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }
    }
}