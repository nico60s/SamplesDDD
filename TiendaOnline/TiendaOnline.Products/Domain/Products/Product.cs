using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class Product : Entity, IHasDomainEvents
    {
        private readonly string _description;

        public Product(ProductId id, string description) : base(id)
        {
            _description = description;
        }

        public IReadOnlyCollection<IDomainEvent> Events => throw new NotImplementedException();
    }
}
