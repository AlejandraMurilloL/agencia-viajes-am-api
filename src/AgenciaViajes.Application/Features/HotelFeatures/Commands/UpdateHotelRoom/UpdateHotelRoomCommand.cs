using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using FluentValidation;
using MongoDB.Bson;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom
{
    public class UpdateHotelRoomCommand : IUpdateHotelRoomCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IValidator<UpdateHotelRoomRequest> _validator;

        public UpdateHotelRoomCommand(
            IRepository<Hotel> hotelRespository,
            IValidator<UpdateHotelRoomRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRoomRequest model)
        {
            ValidateModel(model);

            var hotel = await _hotelRespository.FindOneAsync(x => x.Id == ObjectId.Parse(model.HotelId));

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

            await _hotelRespository.ReplaceOneAsync(hotelUpdated);
        }

        private void ValidateModel(UpdateHotelRoomRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
