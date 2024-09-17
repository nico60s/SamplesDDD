using TiendaOnline.Catalog.Domain.Catalog.Events;
using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Catalog.Application.Features.Catalogs.Create
{
    public class CatalogCreatedEventHandler : IDomainEventHandler<CatalogCreatedDomainEvent>
    {
        public Task Handle(CatalogCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
