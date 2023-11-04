namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public class UpdateHotelStatusRequest
    {
        public required string Id { get; set; }
        public bool Active { get; set; }
    }
}
