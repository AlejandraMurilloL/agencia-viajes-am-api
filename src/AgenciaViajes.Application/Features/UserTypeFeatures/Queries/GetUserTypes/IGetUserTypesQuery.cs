using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes
{
    public interface IGetUserTypesQuery
    {
        Task<List<GetUserTypesResponse>> Execute();
    }
}
