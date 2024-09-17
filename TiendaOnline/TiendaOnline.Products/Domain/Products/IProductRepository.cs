

namespace TiendaOnline.Products.Domain.Products
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
    }
}
