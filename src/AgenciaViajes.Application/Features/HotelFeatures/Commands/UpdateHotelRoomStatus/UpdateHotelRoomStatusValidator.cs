using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public class UpdateHotelRoomStatusValidator : AbstractValidator<UpdateHotelRoomStatusRequest>
    {
        public UpdateHotelRoomStatusValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Id de la Habitación es obligatorio");

            RuleFor(x => x.HotelId)
                .NotNull()
                .NotEmpty()
                .WithMessage("El Id del Hotel es obligatorio");

        }
    }
}
