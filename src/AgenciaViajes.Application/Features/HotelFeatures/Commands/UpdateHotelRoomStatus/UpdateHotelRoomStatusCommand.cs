using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using FluentValidation;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus
{
    public class UpdateHotelRoomStatusCommand: IUpdateHotelRoomStatusCommand
    {
        private readonly IRepository<Hotel> _hotelRespository;
        private readonly IValidator<UpdateHotelRoomStatusRequest> _validator;

        public UpdateHotelRoomStatusCommand(
            IRepository<Hotel> hotelRespository,
            IValidator<UpdateHotelRoomStatusRequest> validator)
        {
            _hotelRespository = hotelRespository;
            _validator = validator;
        }

        public async Task Execute(UpdateHotelRoomStatusRequest model)
        {
            ValidateModel(model);

            var hotel = await _hotelRespository.FindOneAsync(x => x.Id == ObjectId.Parse(model.HotelId));

            if (hotel == null)
                throw new NotFoundException($"El Hotel con Id {model.HotelId} no existe.");

            var room = hotel.GetRoom(model.Id);

            if (room == null)
                throw new NotFoundException($"La habitación con Id {model.Id} no existe.");

            var roomUpdated = room.WithStatus(model.Active);
            var hotelUpdated = hotel.UpdateRoom(roomUpdated);

            await _hotelRespository.ReplaceOneAsync(hotelUpdated);
        }

        private void ValidateModel(UpdateHotelRoomStatusRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
