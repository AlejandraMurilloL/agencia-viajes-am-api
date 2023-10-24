using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetUserTypesResponse>>> GetById(
            [FromServices] IGetUserTypesQuery getUserTypes)
        {
            var response = await getUserTypes.Execute();
            return Ok(response);
        }
    }
}
