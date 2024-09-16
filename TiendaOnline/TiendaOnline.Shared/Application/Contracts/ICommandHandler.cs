
using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface ICommandHandler : IRequestHandler<ICommand>
    {
        Task HandleAsync(ICommand command);
    }
    public interface ICommandHandler<TResult> : IRequestHandler<ICommand> where TResult : ICommand<TResult> 
    { 
        Task<TResult> HandleAsync(ICommand command);
    }

}
