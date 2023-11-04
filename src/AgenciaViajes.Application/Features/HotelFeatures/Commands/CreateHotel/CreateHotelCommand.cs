using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Domain.Entities;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel
{
    public class CreateHotelCommand : ICreateHotelCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<CreateHotelRequest> _validator;

        public CreateHotelCommand(
            IUnitOfWork unitOfWork, 
            IValidator<CreateHotelRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(CreateHotelRequest model)
        {
            ValidateModel(model);

            var newHotel = new Hotel()
                .WithName(model.Name)
                .WithCity(model.City)
                .WithDescription(model.Description ?? string.Empty);

            await _unitOfWork.HotelRepository.AddAsync(newHotel);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(CreateHotelRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
