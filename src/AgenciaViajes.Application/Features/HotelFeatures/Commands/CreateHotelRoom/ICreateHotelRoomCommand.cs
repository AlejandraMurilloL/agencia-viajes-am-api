using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public interface ICreateHotelRoomCommand
    {
        Task Execute(CreateHotelRoomRequest model);
    }
}
