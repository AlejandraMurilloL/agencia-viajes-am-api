using AgenciaViajes.Application.Common.Exceptions;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public class UpdateHotelRoomStatusCommand: IUpdateHotelRoomStatusCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UpdateHotelRoomStatusRequest> _validator;

        public UpdateHotelRoomStatusCommand(
            IUnitOfWork unitOfWork,
            IValidator<UpdateHotelRoomStatusRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRoomStatusRequest model)
        {
            ValidateModel(model);

            var hotel = await _unitOfWork.HotelRepository.GetByIdAsync(model.HotelId);

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.HotelId} no existe.");

            var room = hotel.GetRoom(model.Id);

            if (room == null)
                throw new NotFoundException($"La habitación con Id {model.Id} no existe.");

            var roomUpdated = room.WithStatus(model.Active);
            var hotelUpdated = hotel.UpdateRoom(roomUpdated);

            await _unitOfWork.HotelRepository.UpdateAsync(hotelUpdated);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(UpdateHotelRoomStatusRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
