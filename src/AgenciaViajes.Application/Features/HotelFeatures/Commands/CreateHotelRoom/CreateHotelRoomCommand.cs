using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Domain.Entities;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public class CreateHotelRoomCommand : ICreateHotelRoomCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<CreateHotelRoomRequest> _validator;

        public CreateHotelRoomCommand(
            IUnitOfWork unitOfWork,
            IValidator<CreateHotelRoomRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(CreateHotelRoomRequest model)
        {
            ValidateModel(model);

            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(model.HotelId);

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.HotelId} no existe.");

            var newRoom = new Room(model.HotelId)
                .WithName(model.Name)
                .WithBaseCost(model.BaseCost)
                .WithTaxes(model.Taxes)
                .WithRoomTypeId(model.RoomTypeId)
                .WithLocation(model.Location);

            var hotelUpdated = hotel.AddRoom(newRoom);

            await _unitOfWork.HotelRepository.UpdateAsync(hotelUpdated);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(CreateHotelRoomRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
