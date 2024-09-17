

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog.Events
{
    public class CatalogCreatedDomainEvent : DomainEvent
    {
        public CatalogId CatalogId { get; private set; }
        public CatalogCreatedDomainEvent(CatalogId catalogId) => CatalogId = catalogId;
       
    }
}
