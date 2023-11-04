using AgenciaViajes.Application.Features.RoomTypes.Queries.GetAllRoomTypes;
using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetAllRoomTypesResponse>>> GetAll(
            [FromServices] IGetAllRoomTypesQuery getRoomTypes)
        {
            var response = await getRoomTypes.Execute();
            return Ok(response);
        }
    }
}
