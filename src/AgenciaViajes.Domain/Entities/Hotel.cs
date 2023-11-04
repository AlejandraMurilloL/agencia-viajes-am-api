using AgenciaViajes.Domain.Common;

namespace AgenciaViajes.Domain.Entities;

public partial class Hotel : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string City { get; set; } = null!;
    public bool Active { get; set; }
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public Hotel()
    {
        Active = true;
    }

    public Hotel WithName(string name)
    {
        Name = name;
        return this;
    }
    public Hotel WithDescription(string description)
    {
        Description = description;
        return this;
    }

    public Hotel WithCity(string city)
    {
        City = city;
        return this;
    }

    public Hotel WithState(bool active)
    {
        Active = active;
        return this;
    }

    public Hotel AddRoom(Room room)
    {
        Rooms.Add(room);
        return this;
    }

    public Room GetRoom(int roomId)
    {
        return Rooms.First(r => r.Id == roomId);
    }

    public Hotel UpdateRoom(Room room)
    {
        Rooms = Rooms.Where(x => x.Id != room.Id).ToList();
        Rooms.Add(room);

        return this;
    }
}
