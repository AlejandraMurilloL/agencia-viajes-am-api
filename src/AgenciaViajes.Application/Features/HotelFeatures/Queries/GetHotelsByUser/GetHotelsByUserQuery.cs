using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser
{
    public class GetHotelsByUserQuery : IGetHotelsByUserQuery
    {
        private readonly IRepository<Hotel> _hotelRepository;
        private readonly IMapper _mapper;

        public GetHotelsByUserQuery(
            IRepository<Hotel> hotelRepository,
            IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public async Task<List<GetHotelsByUserResponse>> Execute()
        {
            var hotels = _hotelRepository.AsQueryable();

            if (hotels == null)
                return new List<GetHotelsByUserResponse>();

            return _mapper.Map<List<GetHotelsByUserResponse>>(hotels);
        }
    }
}
