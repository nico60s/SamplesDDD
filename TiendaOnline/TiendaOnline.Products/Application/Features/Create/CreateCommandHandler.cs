

using TiendaOnline.Products.Domain.Products;
using TiendaOnline.Products.Domain.Products.Events;
using TiendaOnline.Shared.Application.Contracts;
using TiendaOnline.Shared.Infrastructure.DomainEventsDispatching;

namespace TiendaOnline.Products.Application.Features.Create
{
    internal class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IDomainEventDispatcher _domainEventDispatcher;
        public CreateCommandHandler(IProductRepository productRepository, 
                        IDomainEventDispatcher domainEventDispatcher)
        {
            _productRepository = productRepository;
            _domainEventDispatcher = domainEventDispatcher;
        }
        public async Task Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var product = Product.Create(id: ProductId.New(), description: request.Description);
            await _productRepository.AddAsync(product);

            var productCreatedEvent = new ProductCreatedDomainEvent(product.Id.Fr);

            await _domainEventDispatcher.DispatchAsync(product.Events);

        }
    }
}
