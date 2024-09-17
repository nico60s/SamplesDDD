using TiendaOnline.Products.Domain.Products.Events;
using TiendaOnline.Products.Domain.Products.Rules;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class Product : Entity<ProductId>, IHasDomainEvents
    {
        private readonly string _description;
        private List<DomainEvent> _events; 

        private Product(ProductId id, string description) : base(id)
        {
            CheckRule(new HasMaxLengthRule(description, 500));
            _description = description;
            _events = [new ProductCreatedDomainEvent(id)];
        }
        public static Product Create(ProductId id, string description) => new(id, description);

        public void AddEvent(DomainEvent domainEvent)
        {
            _events.Add(domainEvent);
        }

        public IReadOnlyCollection<DomainEvent> Events => _events;

    }
}
