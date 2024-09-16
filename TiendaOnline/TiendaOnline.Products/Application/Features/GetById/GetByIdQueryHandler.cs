
using TiendaOnline.Shared.Application.Contracts;
namespace TiendaOnline.Products.Application.Features.GetById
{
    public class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, GetByIdQueryResponse>
    {
        public Task<GetByIdQueryResponse> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
