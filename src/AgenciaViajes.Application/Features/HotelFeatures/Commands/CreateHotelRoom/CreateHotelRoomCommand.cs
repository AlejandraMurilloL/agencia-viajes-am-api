using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using FluentValidation;
using MongoDB.Bson;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom
{
    public class CreateHotelRoomCommand : ICreateHotelRoomCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IValidator<CreateHotelRoomRequest> _validator;

        public CreateHotelRoomCommand(
            IRepository<Hotel> hotelRespository,
            IValidator<CreateHotelRoomRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _validator = validator;
        }

        public async Task Execute(CreateHotelRoomRequest model)
        {
            ValidateModel(model);

            var hotel = await _hotelRespository.FindOneAsync(x => x.Id == ObjectId.Parse(model.HotelId));

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.HotelId} no existe.");

            var newRoom = new Room(model.HotelId)
                .WithName(model.Name)
                .WithBaseCost(model.BaseCost)
                .WithTaxes(model.Taxes)
                .WithRoomTypeId(model.RoomTypeId)
                .WithLocation(model.Location);

            var hotelUpdated = hotel.AddRoom(newRoom);

            await _hotelRespository.ReplaceOneAsync(hotelUpdated);
        }

        private void ValidateModel(CreateHotelRoomRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
