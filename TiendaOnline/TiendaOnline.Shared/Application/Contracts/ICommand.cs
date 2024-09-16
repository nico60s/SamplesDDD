

using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface ICommand : IRequest
    {
        void ExecuteAsync(ICommand command);
    }

    public interface ICommand<T> : IRequest<T>
    {
        Task<T> ExecuteAsync(T command);
    }
}
