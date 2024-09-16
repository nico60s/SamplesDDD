
using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand>
        where TCommand : ICommand
    {
    }

}
