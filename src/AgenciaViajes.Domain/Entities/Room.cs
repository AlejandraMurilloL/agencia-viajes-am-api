using AgenciaViajes.Domain.Common;

namespace AgenciaViajes.Domain.Entities;

public partial class Room : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal BaseCost { get; set; }
    public decimal Taxes { get; set; }
    public string Location { get; set; } = null!;
    public bool Active { get; set; }
    public int HotelId { get; set; }
    public int RoomTypeId { get; set; }
    public virtual Hotel Hotel { get; set; } = null!;
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public virtual RoomType RoomType { get; set; } = null!;

    public Room(int hotelId)
    {
        HotelId = hotelId;
        Active = true;
    }

    public Room WithName(string name)
    {
        Name = name;
        return this;
    }

    public Room WithBaseCost(decimal baseCost)
    {
        BaseCost = baseCost;
        return this;
    }

    public Room WithTaxes(decimal taxes)
    {
        Taxes = taxes;
        return this;
    }

    public Room WithRoomTypeId(int roomTypeId)
    {
        RoomTypeId = roomTypeId;
        return this;
    }

    public Room WithLocation(string location)
    {
        Location = location;
        return this;
    }

    public Room WithStatus(bool active)
    {
        Active = active;
        return this;
    }
}
