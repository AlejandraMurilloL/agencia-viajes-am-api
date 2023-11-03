using AgenciaViajes.Domain.Entities;
using AutoMapper;

namespace AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes
{
    public class GetUserTypesMapper : Profile
    {
        public GetUserTypesMapper()
        {
            CreateMap<UserType, GetUserTypesResponse>();
        }
    }
}
