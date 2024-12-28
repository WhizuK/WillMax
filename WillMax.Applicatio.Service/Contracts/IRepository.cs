using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface IRepository<TEntity, TPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task <TEntity> GetById(TPrimaryKey id);
        Task<TEntity> Create(TEntity entity);
        TEntity Update(TEntity entity);
        Task<TEntity> DeleteById (TPrimaryKey id);
        TEntity Delete(TEntity entity);
    }
}
