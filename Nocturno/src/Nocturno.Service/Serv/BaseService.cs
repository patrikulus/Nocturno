using Nocturno.Repository.Common;
using Nocturno.Repository.IRepo;
using Nocturno.Service.IServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Serv
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _uow;
        private readonly IBaseRepo<TEntity> _repo;

        public BaseService(IUnitOfWork uow, IBaseRepo<TEntity> repo)
        {
            _uow = uow;
            _repo = repo;
        }

        public void Create(TEntity entity)
        {
            _repo.Add(entity);
            _uow.Commit();
        }

        public void Delete(TEntity entity)
        {
            _repo.Remove(entity);
            _uow.Commit();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repo.GetAll();
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
            _uow.Commit();
        }
    }
}