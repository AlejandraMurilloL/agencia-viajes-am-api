using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AutoMapper;
using FluentValidation;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel
{
    public class CreateHotelCommand : ICreateHotelCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateHotelRequest> _validator;

        public CreateHotelCommand(
            IRepository<Hotel> hotelRespository, 
            IMapper mapper, 
            IValidator<CreateHotelRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task Execute(CreateHotelRequest model)
        {
            ValidateModel(model);

            var newHotel = new Hotel()
                .WithName(model.Name)
                .WithCity(model.City)
                .WithDescription(model.Description ?? string.Empty);

            await _hotelRespository.InsertOneAsync(newHotel);
        }

        private void ValidateModel(CreateHotelRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
