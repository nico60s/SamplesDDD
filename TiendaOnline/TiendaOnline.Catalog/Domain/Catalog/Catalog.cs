using TiendaOnline.Catalog.Domain.Catalog.Events;
using TiendaOnline.Catalog.Domain.Catalog.Rules;
using TiendaOnline.Catalog.Domain.shared;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog
{
    public class Catalog : Entity<CatalogId>, IHasDomainEvents
    {
        private readonly List<DomainEvent> _events;
        private readonly string _name;
        private readonly Categories Category;
        private Catalog(CatalogId id, string catalogName, string category) : base(id)
        {
            CheckRule(new CatalogNameMustNotBeNullBusinessRule(catalogName));
            _name = catalogName;
        }

        public IReadOnlyCollection<DomainEvent> Events => _events;

        public static Catalog New(CatalogId id, string catalogName, 
            string category) => new(id, catalogName, category);

        public void AddEvent(DomainEvent domainEvent)
        {
            _events.Add(domainEvent);
        }
    }
}
