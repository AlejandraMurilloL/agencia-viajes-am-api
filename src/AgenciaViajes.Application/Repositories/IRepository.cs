using AgenciaViajes.Domain.Common;
using System.Linq.Expressions;

namespace AgenciaViajes.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task DeleteAsync(TEntity entity);
        Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
