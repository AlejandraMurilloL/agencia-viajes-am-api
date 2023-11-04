namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public class UpdateHotelRoomStatusRequest
    {
        public required string Id { get; set; }
        public required string HotelId { get; set; }
        public bool Active { get; set; }
    }
}
