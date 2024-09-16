using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Api.Controllers.Orders.GetById
{
    public sealed record GetByIdRequest
    {
        [Required] public Guid OrderId { get; set; }
    }
}
