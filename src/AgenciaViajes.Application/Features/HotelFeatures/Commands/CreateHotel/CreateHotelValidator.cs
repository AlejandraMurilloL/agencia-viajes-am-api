using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel
{
    public class CreateHotelValidator : AbstractValidator<CreateHotelRequest>
    {
        public CreateHotelValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Nombre del Hotel es obligatorio");

            RuleFor(x => x.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("La Ciudad en la que se encuentra el Hotel es obligatoria");

        }
    }
}
