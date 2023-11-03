using AgenciaViajes.Domain.Entities;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel
{
    public class CreateHotelRequest
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string City { get; set; }
        public List<Room>? Rooms { get; set; }
    }
}
