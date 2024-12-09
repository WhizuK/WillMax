
using Microsoft.EntityFrameworkCore;
using WillMax.Applicatio.Service.Contracts;

namespace WillMax.Infra.Dta.Repository
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            return (await DbSet.AddAsync(entity)).Entity;
        }

        public TEntity Delete(TEntity entity)
        {
            return (DbSet.Remove(entity)).Entity;
        }

        public async Task<TEntity> DeleteById(TId id)
        {
            var entity = await GetById(id);
            return Delete(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(TId id)
        {
            return await DbSet.FindAsync(id);
        }

        public TEntity Update(TEntity entity)
        {
            return (DbSet.Update(entity)).Entity;
        }
    }
}
