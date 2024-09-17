

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Catalog.Application.Features.Catalogs.Create
{
    public class CreateCommand(string catalogName) : ICommand
    {
        public string CatalogName { get; } = catalogName;
    }
}
