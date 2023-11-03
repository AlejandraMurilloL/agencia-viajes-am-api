namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel
{
    public interface ICreateHotelCommand
    {
        Task Execute(CreateHotelRequest model);
    }
}
