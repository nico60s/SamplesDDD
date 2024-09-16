
using MediatR;

namespace TiendaOnline.Shared.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime OccurredOn { get;  }
        Guid Id { get; }
    }
}
