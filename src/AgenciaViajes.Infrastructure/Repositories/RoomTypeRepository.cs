using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AgenciaViajes.Infrastructure.Database;

namespace AgenciaViajes.Infrastructure.Repositories
{
    public class RoomTypeRepository : Repository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(AgenciaViajesContext context) : base (context)
        {
            
        }
    }
}
