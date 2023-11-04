using AgenciaViajes.Domain.Common;

namespace AgenciaViajes.Domain.Entities;

public partial class Guest : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime Birthday { get; set; }
    public string Gender { get; set; } = null!;
    public string DocumentType { get; set; } = null!;
    public string DocumentNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public int ReservationId { get; set; }
    public virtual Reservation Reservation { get; set; } = null!;
}
