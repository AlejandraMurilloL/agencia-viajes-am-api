namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public class UpdateHotelRoomStatusRequest
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public bool Active { get; set; }
    }
}
