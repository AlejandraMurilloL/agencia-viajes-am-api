using AgenciaViajes.Application.Features.HotelFeatures.Queries.GetHotelsByUser;
using AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetAvailableRooms;
using AgenciaViajes.Application.Features.ReservationFeatures.Queries.GetReservations;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetReservationsResponse>>> Get(
           [FromServices] IGetReservationsQuery getReservations)
        {
            var response = await getReservations.Execute();
            return Ok(response);
        }

        [HttpGet("Available")]
        public async Task<ActionResult<List<GetAvailableRoomsResponse>>> GetAvailableRooms(
           [FromServices] IGetAvailableRoomsQuery getAvailableRooms,
           [FromQuery] GetAvailableRoomsRequest filter)
        {
            var response = await getAvailableRooms.Execute(filter);
            return Ok(response);
        }
    }
}
