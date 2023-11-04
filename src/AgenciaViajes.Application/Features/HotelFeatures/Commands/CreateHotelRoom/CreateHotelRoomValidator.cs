using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public class CreateHotelRoomValidator : AbstractValidator<CreateHotelRoomRequest>
    {
        public CreateHotelRoomValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Nombre de la Habitación es obligatorio");

            RuleFor(x => x.HotelId)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Id del Hotel es obligatorio");

            RuleFor(x => x.BaseCost)
                .NotNull()
                .NotEmpty()
                .NotEqual(0)
                .WithMessage("El Costo Base de la Habitación es obligatorio y debe ser mayor a cero");

            RuleFor(x => x.RoomTypeId)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Tipo de Habitación es obligatorio");

            RuleFor(x => x.Location)
                .NotNull()
                .NotEmpty()
                .WithMessage("La ubicación de la Habitación es obligatoria");
        }
    }
}
