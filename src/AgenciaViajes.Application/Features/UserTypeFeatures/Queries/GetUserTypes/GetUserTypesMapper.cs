using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes
{
    internal class GetUserTypesMapper : Profile
    {
        public GetUserTypesMapper()
        {
            CreateMap<UserType, GetUserTypesResponse>();
        }
    }
}
