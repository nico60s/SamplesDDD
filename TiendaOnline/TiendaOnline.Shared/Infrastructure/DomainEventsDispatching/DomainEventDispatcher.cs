
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Shared.Infrastructure.DomainEventsDispatching
{
    public class DomainEventDispatcher :IDomainEventDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public DomainEventDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task HandleAsync<TEvent>(TEvent @event) where TEvent : DomainEvent
        {
            var handlers = _serviceProvider.GetServices<INotificationHandler<TEvent>>();
            foreach (var handler in handlers)
            {
                await handler.Handle(@event, CancellationToken.None);
            }
        }
    }
}
