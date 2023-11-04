using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public class UpdateHotelStatusValidator : AbstractValidator<UpdateHotelStatusRequest>
    {
        public UpdateHotelStatusValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Id del Hotel es obligatorio");
        }
    }
}
