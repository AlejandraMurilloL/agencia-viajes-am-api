namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public interface IUpdateHotelRoomStatusCommand
    {
        Task Execute(UpdateHotelRoomStatusRequest model);
    }
}
