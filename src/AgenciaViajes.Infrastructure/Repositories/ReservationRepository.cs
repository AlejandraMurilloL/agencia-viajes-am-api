using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AgenciaViajesContext context) : base(context)
        {
            
        }
    }
}
