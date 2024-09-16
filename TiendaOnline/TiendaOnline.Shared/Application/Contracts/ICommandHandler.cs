
using MediatR;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface ICommandHandler : IRequestHandler<ICommand>
    {
    }

}
