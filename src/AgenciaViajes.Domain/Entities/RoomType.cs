using AgenciaViajes.Domain.Common;

namespace AgenciaViajes.Domain.Entities;

public partial class RoomType : BaseEntity
{
    public string Name { get; set; } = null!;
    public int PeopleCapacity { get; set; }
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
