

using TiendaOnline.Shared.Application.Contracts;

namespace TiendaOnline.Catalog.Application.Features.Catalogs.Create
{
    public class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        public Task Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
