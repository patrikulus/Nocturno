using System.Collections.Generic;

namespace Nocturno.Service.IServ
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity GetByName(string name);

        void Commit();
    }
}