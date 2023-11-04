using AgenciaViajes.Application.Common.Exceptions;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public class UpdateHotelStatusCommand : IUpdateHotelStatusCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UpdateHotelStatusRequest> _validator;

        public UpdateHotelStatusCommand(
            IUnitOfWork unitOfWork,
            IValidator<UpdateHotelStatusRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelStatusRequest model)
        {
            ValidateModel(model);

            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(model.Id);

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.Id} no existe.");

            var hotelUpdated = hotel.WithState(model.Active);
            await _unitOfWork.HotelRepository.UpdateAsync(hotelUpdated);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(UpdateHotelStatusRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
