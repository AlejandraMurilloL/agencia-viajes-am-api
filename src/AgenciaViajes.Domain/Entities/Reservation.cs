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

    public Reservation WithStartDate(DateTime startDate)
    {
        StartDate = startDate;
        return this;
    }

    public Reservation WithEndDate(DateTime endDate)
    {
        EndDate = endDate;
        return this;
    }

    public Reservation WithContactInfo(string contactName, string contactPhone)
    {
        ContactName = contactName;
        ContactPhone = contactPhone;
        return this;
    }

    public Reservation WithRoomInfo(int hotelId, int roomId)
    {
        HotelId = hotelId;
        RoomId = roomId;
        return this;
    }

    public Reservation WithGuests(List<Guest> guests)
    {
        Guests = guests;
        return this;
    }
}
