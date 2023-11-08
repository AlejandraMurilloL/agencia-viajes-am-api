using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(AgenciaViajesContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Hotel>> GetAllAsync()
        {
            return await _entities
                .Include(x => x.Rooms)
                    .ThenInclude(x => x.RoomType)
                .ToListAsync();
        }

        public async override Task<Hotel> GetByIdAsync(int id)
        {
            return await _entities
                .Where(x => x.Id == id)
                .Include(x => x.Rooms)
                    .ThenInclude(x => x.RoomType)
                .FirstAsync();
        }
    }
}
