using AgenciaViajes.Domain.Common;

namespace AgenciaViajes.Domain.Entities;

public partial class Reservation : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ContactName { get; set; } = null!;
    public string ContactPhone { get; set; } = null!;
    public int HotelId { get; set; }
    public int RoomId { get; set; }
    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();
    public virtual Hotel Hotel { get; set; } = null!;
    public virtual Room Room { get; set; } = null!;
}
