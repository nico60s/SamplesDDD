

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain
{
    public class Product : Entity<ProductId>
    {
        public Product(ProductId id) : base(id)
        {
        }
    }
}
