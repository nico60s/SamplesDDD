using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class Product : Entity<ProductId>
    {
        private readonly string _description;

        public Product(ProductId id, string description) : base(id)
        {
            _description = description;
        }
    }
}
