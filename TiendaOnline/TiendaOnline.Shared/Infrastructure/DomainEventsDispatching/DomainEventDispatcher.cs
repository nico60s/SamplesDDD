
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TiendaOnline.Shared.Application.Contracts;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Shared.Infrastructure.DomainEventsDispatching
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IServiceProvider _serviceProvider;

        public DomainEventDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task DispatchAsync<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            var handlers = _serviceProvider.GetServices<INotificationHandler<TEvent>>();
            foreach (var handler in handlers)
            {
                await handler.Handle(@event, CancellationToken.None);
            }
        }
    }
}
