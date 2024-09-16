

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products.Events
{
    public class ProductCreatedDomainEvent : DomainEvent
    {
        public ProductId ProductId { get; private set; }
        public ProductCreatedDomainEvent(ProductId productId)
        {
            ProductId = productId;
        }

    }
}
