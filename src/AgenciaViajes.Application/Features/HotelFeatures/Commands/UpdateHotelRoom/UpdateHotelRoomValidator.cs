using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public class UpdateHotelRoomValidator : AbstractValidator<UpdateHotelRoomRequest>
    {
        public UpdateHotelRoomValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Nombre de la Habitación es obligatorio");

            RuleFor(x => x.BaseCost)
                .NotNull()
                .NotEmpty()
                .NotEqual(0)
                .WithMessage("El Costo Base de la Habitación es obligatorio y debe ser mayor a cero");

            RuleFor(x => x.Location)
                .NotNull()
                .NotEmpty()
                .WithMessage("La ubicación de la Habitación es obligatoria");
        }
    }
}
