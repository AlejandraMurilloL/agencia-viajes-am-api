using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AgenciaViajesContext context) : base(context)
        {
            
        }

        public async override Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _entities
                .Include(x => x.Hotel)
                .Include(x => x.Room)
                .Include(x => x.Guests)
                .ToListAsync();
        }
    }
}
