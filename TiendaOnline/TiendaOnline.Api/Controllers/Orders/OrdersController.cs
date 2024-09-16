using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Api.Controllers.Orders.GetById;

namespace TiendaOnline.Api.Controllers.Orders
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        [Route(".json")] 
        public async Task<IActionResult> GetById([FromQuery]GetByIdRequest request)
        {
            return Ok(request.OrderId);
        }
    }
}
