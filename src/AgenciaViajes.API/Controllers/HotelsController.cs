using AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser;
using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetUserTypesResponse>>> GetByUser(
           [FromServices] IGetHotelsByUserQuery getHotelsByUser)
        {
            var response = await getHotelsByUser.Execute();
            return Ok(response);
        }
    }
}
