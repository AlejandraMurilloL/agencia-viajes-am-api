namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public interface IUpdateHotelRoomCommand
    {
        Task Execute(UpdateHotelRoomRequest model);
    }
}
