namespace AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes
{
    public class GetAllRoomTypesResponse
    {
        public required string Id { get; set; }
        public required string Name { get; set; } 
        public int PeopleCapacity { get; set; }

    }
}
