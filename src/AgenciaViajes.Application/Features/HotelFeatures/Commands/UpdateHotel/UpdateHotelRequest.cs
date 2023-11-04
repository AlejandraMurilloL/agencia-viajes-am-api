namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel
{
    public class UpdateHotelRequest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string City { get; set; }
    }
}
