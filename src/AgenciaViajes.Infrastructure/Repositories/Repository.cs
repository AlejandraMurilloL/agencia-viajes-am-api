using AgenciaViajes.Domain.Common;
using AgenciaViajes.Application.Repositories;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using AgenciaViajes.Infrastructure.Database;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        internal AgenciaViajesContext Context;
        internal DbSet<TEntity> _entities;

        public Repository(AgenciaViajesContext context)
        {
            Context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _entities.Update(entity); });
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entities.FirstAsync(e => e.Id == id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { Delete(entity); });
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.AnyAsync(predicate);
        }
    }
}
