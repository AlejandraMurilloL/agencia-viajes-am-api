namespace AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes
{
    public interface IGetAllRoomTypesQuery
    {
        Task<List<GetAllRoomTypesResponse>> Execute();
    }
}
