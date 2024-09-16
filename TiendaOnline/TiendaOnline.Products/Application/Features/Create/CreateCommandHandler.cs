

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Products.Application.Features.Create
{
    internal class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        public Task Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
