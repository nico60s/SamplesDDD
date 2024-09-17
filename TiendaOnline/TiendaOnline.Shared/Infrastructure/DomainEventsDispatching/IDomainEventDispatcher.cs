

using MediatR;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Shared.Infrastructure.DomainEventsDispatching
{
    public interface IDomainEventDispatcher : INotificationHandler<DomainEvent>
    {
        Task DispatchAsync(IDomainEvent @event);

    }
}
