using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using FluentValidation;
using MongoDB.Bson;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel
{
    public class UpdateHotelCommand : IUpdateHotelCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IValidator<UpdateHotelRequest> _validator;

        public UpdateHotelCommand(
            IRepository<Hotel> hotelRespository,
            IValidator<UpdateHotelRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRequest model)
        {
            ValidateModel(model);

            var hotel = await _hotelRespository.FindOneAsync(x => x.Id == ObjectId.Parse(model.Id));

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.Id} no existe.");

            var hotelUpdated = hotel
                .WithName(model.Name)
                .WithDescription(model.Description ?? string.Empty)
                .WithCity(model.City);

            await _hotelRespository.ReplaceOneAsync(hotelUpdated);
        }

        private void ValidateModel(UpdateHotelRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
