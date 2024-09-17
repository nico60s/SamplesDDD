

using MediatR;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Shared.Application.Contracts
{
    public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
        where TEvent: IDomainEvent
    {
        
    }
}
