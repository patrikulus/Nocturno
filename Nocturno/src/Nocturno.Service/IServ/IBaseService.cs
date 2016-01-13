using System.Collections.Generic;

namespace Nocturno.Service.IServ
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);
    }
}