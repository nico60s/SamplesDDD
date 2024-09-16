

using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
   public interface IQueryHandler<TQuery,TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>


    {
    }
}
