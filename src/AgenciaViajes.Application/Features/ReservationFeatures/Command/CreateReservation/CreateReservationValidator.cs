using FluentValidation;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Command.CreateReservation
{
    public class CreateReservationValidator : AbstractValidator<CreateReservationRequest>
    {
        public CreateReservationValidator()
        {
            RuleFor(x => x.HotelId)
                .NotNull()
                .NotEqual(0)
                .WithMessage("El Hotel es obligatorio para crear una Reserva");

            RuleFor(x => x.RoomId)
                .NotNull()
                .NotEqual(0)
                .WithMessage("La Habitación es obligatoria para crear una Reserva");

            RuleFor(x => x.StartDate)
                .NotNull()
                .WithMessage("La Fecha de Llegada es obligatoria para crear una Reserva");

            RuleFor(x => x.EndDate)
                .NotNull()
                .WithMessage("La Fecha de Salida es obligatoria para crear una Reserva");

            RuleFor(x => x.ContactName)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Nombre de Contacto es obligatorio para crear una Reserva");

            RuleFor(x => x.ContactPhone)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Numero de Contacto es obligatorio para crear una Reserva");

            RuleFor(x => x.Guests)
                .NotEmpty()
                .WithMessage("Debe ingresar la información de los huéspedes para crear una Reserva");
        }
    }
}
