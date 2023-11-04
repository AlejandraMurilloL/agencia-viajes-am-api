namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public class UpdateHotelRoomRequest
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int HotelId { get; set; }
        public decimal BaseCost { get; set; }
        public decimal Taxes { get; set; }
        public required string Location { get; set; }
    }
}
