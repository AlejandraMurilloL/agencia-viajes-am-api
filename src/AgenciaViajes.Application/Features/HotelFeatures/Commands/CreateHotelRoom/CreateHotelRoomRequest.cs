namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public class CreateHotelRoomRequest
    {
        public required string Name { get; set; }
        public required string HotelId { get; set; }
        public double BaseCost { get; set; }
        public double Taxes { get; set; }
        public required string RoomTypeId { get; set; }
        public required string Location { get; set; }
    }
}
