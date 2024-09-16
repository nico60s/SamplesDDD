

using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface IQuery<out T> : IRequest<T>
    {
        
    }
}
