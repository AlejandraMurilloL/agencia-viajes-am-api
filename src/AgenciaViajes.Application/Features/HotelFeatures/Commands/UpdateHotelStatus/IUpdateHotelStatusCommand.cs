namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public interface IUpdateHotelStatusCommand
    {
        Task Execute(UpdateHotelStatusRequest model);
    }
}
