using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser;
using AgenciaViajes.Application.Features.UserTypeFeatures.Queries.GetUserTypes;
using AgenciaViajes.Domain.Entities;
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

        [HttpPost]
        public async Task<ActionResult> Post(
           [FromServices] ICreateHotelCommand createHotel, 
           CreateHotelRequest hotel)
        {
            await createHotel.Execute(hotel);
            return Ok();
        }
    }
}
