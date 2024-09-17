

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Catalog.Application.Features.Categories.Create
{
    public class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        public Task Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
