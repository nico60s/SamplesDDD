using TiendaOnline.Catalog.Domain.Catalog.Events;
using TiendaOnline.Catalog.Domain.Catalog.Rules;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog
{
    public class Catalog : Entity, IHasDomainEvents
    {
        private readonly List<DomainEvent> _events;
        private readonly string _name;
        private Catalog(CatalogId id, string catalogName) : base(id)
        {
            CheckRule(new CatalogNameMustNotBeNullBusinessRule(catalogName));
            _name = catalogName;
            _events = [new CatalogCreatedDomainEvent(id)];
        }

        public IReadOnlyCollection<IDomainEvent> Events => _events;

        public static Catalog New(CatalogId id, string catalogName) => new(id, catalogName);
    }
}
