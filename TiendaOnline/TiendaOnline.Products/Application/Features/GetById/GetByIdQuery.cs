

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Products.Application.Features.GetById
{
    public class GetByIdQuery : IQuery<GetByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
