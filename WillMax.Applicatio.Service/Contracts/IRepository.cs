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
        Task<IEnumerable<TEntity>> GetById(TPrimaryKey id);
        Task<IEnumerable<TEntity>> Create(TEntity entity);
        Task<IEnumerable<TEntity>> Update(TEntity entity);
        Task<IEnumerable<TEntity>> DeleteById(TPrimaryKey id);
        Task<IEnumerable<TPrimaryKey>> Delete(TPrimaryKey id);
    }
}
