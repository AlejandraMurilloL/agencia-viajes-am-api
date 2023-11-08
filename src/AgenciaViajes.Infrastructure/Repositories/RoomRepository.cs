using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(AgenciaViajesContext context) : base(context)
        {
            
        }

        public async override Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _entities
                .Include(x => x.RoomType)
                .Include(x => x.Hotel)
                .ToListAsync();
        }
    }
}
