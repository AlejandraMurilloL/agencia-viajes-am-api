namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelById
{
    public interface IGetHotelByIdQuery
    {
        Task<GetHotelByIdResponse> Execute(int id);
    }
}
