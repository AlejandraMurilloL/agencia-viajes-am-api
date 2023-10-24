using AgenciaViajes.Application.Common.Exceptions;
using AgenciaViajes.Application.Repositories;
using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes
{
    internal class GetUserTypesQuery : IGetUserTypesQuery
    {
        private readonly IRepository<UserType> _userTypeRepository;
        private readonly IMapper _mapper;

        public GetUserTypesQuery(IRepository<UserType> userTypeRepository, IMapper mapper)
        {
            _userTypeRepository = userTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GetUserTypesResponse>> Execute()
        {
            var userTypes = _userTypeRepository.AsQueryable();

            if (userTypes == null)
                throw new NotFoundException($"No existen Tipos de Usuario creados");

            return _mapper.Map<List<GetUserTypesResponse>>(userTypes);
        }
    }
}
