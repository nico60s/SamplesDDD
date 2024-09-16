using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiendaOnline.Api.Controllers.Products
{
    [Route("api/v{version}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route(".json")]
        public IActionResult GetById(Guid id)
        {
            return Ok(id);
        }
        [HttpGet]
        public IActionResult GetAll() { return Ok(); }
    }
}
