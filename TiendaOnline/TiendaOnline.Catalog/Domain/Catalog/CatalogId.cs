using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog
{
    public class CatalogId : IdValueObject
    {
        protected CatalogId(Guid id) : base(id)
        {
        }
        public static CatalogId CreateNew() => new(Guid.NewGuid());
    }
}
