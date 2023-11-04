using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using FluentValidation;
using MongoDB.Bson;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus
{
    public class UpdateHotelStatusCommand : IUpdateHotelStatusCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IValidator<UpdateHotelStatusRequest> _validator;

        public UpdateHotelStatusCommand(
            IRepository<Hotel> hotelRespository,
            IValidator<UpdateHotelStatusRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelStatusRequest model)
        {
            ValidateModel(model);

            var hotel = await _hotelRespository.FindOneAsync(x => x.Id == ObjectId.Parse(model.Id));

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.Id} no existe.");

            var hotelUpdated = hotel.WithState(model.Active);
            await _hotelRespository.ReplaceOneAsync(hotelUpdated);
        }

        private void ValidateModel(UpdateHotelStatusRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
