namespace AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes
{
    public interface IGetUserTypesQuery
    {
        Task<List<GetUserTypesResponse>> Execute();
    }
}
