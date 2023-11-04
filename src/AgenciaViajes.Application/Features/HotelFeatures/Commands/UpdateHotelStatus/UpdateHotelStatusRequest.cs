namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public class UpdateHotelStatusRequest
    {
        public int Id { get; set; }
        public bool Active { get; set; }
    }
}
