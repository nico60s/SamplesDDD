using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class ProductId : IdValueObject
    {
        protected ProductId(Guid id) : base(id)
        {
        }
        public static ProductId New() => new(Guid.NewGuid());
        public static ProductId FromValue(Guid id) => new(id);
    }
}
