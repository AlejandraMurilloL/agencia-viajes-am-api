namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel
{
    public interface IUpdateHotelCommand
    {
        Task Execute(UpdateHotelRequest model);
    }
}
