using AgenciaViajes.Application.Common.Exceptions;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public class UpdateHotelRoomCommand : IUpdateHotelRoomCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UpdateHotelRoomRequest> _validator;

        public UpdateHotelRoomCommand(
            IUnitOfWork unitOfWork,
            IValidator<UpdateHotelRoomRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRoomRequest model)
        {
            ValidateModel(model);

            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(model.HotelId);

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.HotelId} no existe.");

            var room = hotel.GetRoom(model.Id);

            if (room == null)
                throw new NotFoundException($"La habitación con Id {model.Id} no existe.");

            var roomUpdated = room.WithName(model.Name)
                .WithBaseCost(model.BaseCost)
                .WithTaxes(model.Taxes)
                .WithLocation(model.Location);

            var hotelUpdated = hotel.UpdateRoom(roomUpdated);

            await _unitOfWork.HotelRepository.UpdateAsync(hotelUpdated);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(UpdateHotelRoomRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
