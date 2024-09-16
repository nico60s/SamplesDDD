

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Products.Application.Features.Create
{
    public record CreateCommand : ICommand
    {
        string Description { get; set; }
    }
}
