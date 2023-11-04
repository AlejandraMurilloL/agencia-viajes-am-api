using AgenciaViajes.Application.Common.Exceptions;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel
{
    public class UpdateHotelCommand : IUpdateHotelCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UpdateHotelRequest> _validator;

        public UpdateHotelCommand(
            IUnitOfWork unitOfWork,
            IValidator<UpdateHotelRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRequest model)
        {
            ValidateModel(model);

            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(model.Id);

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.Id} no existe.");

            var hotelUpdated = hotel
                .WithName(model.Name)
                .WithDescription(model.Description ?? string.Empty)
                .WithCity(model.City);

            await _unitOfWork.HotelRepository.UpdateAsync(hotelUpdated);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(UpdateHotelRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
