using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser
{
    public interface IGetHotelsByUserQuery
    {
        Task<List<GetHotelsByUserResponse>> Execute();
    }
}
