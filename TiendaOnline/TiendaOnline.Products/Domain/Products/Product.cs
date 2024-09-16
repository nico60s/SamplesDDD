using TiendaOnline.Products.Domain.Products.Events;
using TiendaOnline.Products.Domain.Products.Rules;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class Product : Entity, IHasDomainEvents
    {
        private readonly string _description;
        private List<IDomainEvent> _events; 

        private Product(ProductId id, string description) : base(id)
        {
            CheckRule(new HasMaxLengthRule(description, 500));
            _description = description;
            _events = [new ProductCreatedDomainEvent(id)];
        }
        public static Product Create(ProductId id, string description) => new(id, description); 
        
        public IReadOnlyCollection<IDomainEvent> Events => _events;
    }
}
