

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Shared.Infrastructure.DomainEventsDispatching
{
    public interface IDomainEventDispatcher 
    {
        Task HandleAsync<TEvent>(TEvent @event) where TEvent : DomainEvent;

    }
}
