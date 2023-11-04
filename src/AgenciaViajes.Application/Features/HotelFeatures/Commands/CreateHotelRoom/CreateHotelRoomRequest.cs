namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public class CreateHotelRoomRequest
    {
        public required string Name { get; set; }
        public int HotelId { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Taxes { get; set; }
        public int RoomTypeId { get; set; }
        public required string Location { get; set; }
    }
}
