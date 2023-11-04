namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public class UpdateHotelRoomRequest
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string HotelId { get; set; }
        public double BaseCost { get; set; }
        public double Taxes { get; set; }
        public required string Location { get; set; }
    }
}
