using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.CreateHotelRoom;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotel;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoom;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelRoomStatus;
using AgenciaViajes.Application.Features.HotelFeatures.Commands.UpdateHotelStatus;
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

        [HttpPut("{Id}")]
        public async Task<ActionResult> Put(
           [FromServices] IUpdateHotelCommand updateHotel,
           UpdateHotelRequest hotel)
        {
            await updateHotel.Execute(hotel);
            return Ok();
        }

        [HttpPut("{Id}/Status")]
        public async Task<ActionResult> PutStatus(
           [FromServices] IUpdateHotelStatusCommand updateHotelStatus,
           UpdateHotelStatusRequest hotel)
        {
            await updateHotelStatus.Execute(hotel);
            return Ok();
        }

        [HttpPost("{hotelId}/Rooms")]
        public async Task<ActionResult> PostRoom(
           [FromServices] ICreateHotelRoomCommand createHotelRoom,
           CreateHotelRoomRequest room)
        {
            await createHotelRoom.Execute(room);
            return Ok();
        }

        [HttpPut("{hotelId}/Rooms/{roomId}")]
        public async Task<ActionResult> PutRoom(
           [FromServices] IUpdateHotelRoomCommand updateHotelRoom,
           UpdateHotelRoomRequest room)
        {
            await updateHotelRoom.Execute(room);
            return Ok();
        }

        [HttpPut("{hotelId}/Rooms/{roomId}/Status")]
        public async Task<ActionResult> PutRoomStatus(
           [FromServices] IUpdateHotelRoomStatusCommand updateHotelRoomStatus,
           UpdateHotelRoomStatusRequest room)
        {
            await updateHotelRoomStatus.Execute(room);
            return Ok();
        }
    }
}
