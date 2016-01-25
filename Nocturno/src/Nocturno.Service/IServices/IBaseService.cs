using System.Collections.Generic;

namespace Nocturno.Service.IServices
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Commit();

        void Create(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int? id);

        TEntity GetByName(string name);

        void Update(TEntity entity);
    }
}