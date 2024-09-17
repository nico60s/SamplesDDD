

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Products.Application.Features.Create
{
    public record CreateCommand : ICommand
    {
       public string Description { get; set; }
    }
}
