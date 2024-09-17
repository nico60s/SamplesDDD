using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products
{
    public class ProductId : ValueObject
    {
        public Guid Value { get; }
        protected ProductId(Guid id)
        {
            Value = id;
        }
        public static ProductId New() => new(Guid.NewGuid());
        public static ProductId FromValue(Guid id) => new(id);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
