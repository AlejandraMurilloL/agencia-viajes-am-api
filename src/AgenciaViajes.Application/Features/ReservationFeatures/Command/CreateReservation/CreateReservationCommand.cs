using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Domain.Entities;
using AutoMapper;
using FluentValidation;

namespace AgenciaViajes.Application.Features.ReservationFeatures.Command.CreateReservation
{
    public class CreateReservationCommand : ICreateReservationCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateReservationRequest> _validator;

        public CreateReservationCommand(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IValidator<CreateReservationRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task Execute(CreateReservationRequest model)
        {
            ValidateModel(model);

            var newReservation = new Reservation()
                .WithStartDate(model.StartDate)
                .WithEndDate(model.EndDate)
                .WithContactInfo(model.ContactName, model.ContactPhone)
                .WithRoomInfo(model.HotelId, model.RoomId)
                .WithGuests(_mapper.Map<List<Guest>>(model.Guests));

            await _unitOfWork.ReservationRepository.AddAsync(newReservation);
            await _unitOfWork.SaveAsync();
        }

        private void ValidateModel(CreateReservationRequest model)
        {
            var validate = _validator.Validate(model);
            if (!validate.IsValid)
                throw new BadRequestException(validate.Errors[0].ErrorMessage);
        }
    }
}
