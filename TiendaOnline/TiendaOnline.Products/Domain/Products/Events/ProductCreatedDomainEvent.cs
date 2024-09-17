

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products.Events
{
    public class ProductCreatedDomainEvent : DomainEvent
    {
        public Guid ProductId { get; private set; }
        public ProductCreatedDomainEvent(Guid productId)
        {
            ProductId = productId;
        }

    }
}
