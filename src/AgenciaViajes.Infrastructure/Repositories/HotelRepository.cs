using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(AgenciaViajesContext context) : base(context)
        {
        }
    }
}
