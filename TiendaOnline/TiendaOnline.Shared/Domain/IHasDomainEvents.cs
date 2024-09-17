
namespace TiendaOnline.Shared.Domain
{
    public interface IHasDomainEvents
    {
        IReadOnlyCollection<DomainEvent> Events { get; }
        void AddEvent(DomainEvent domainEvent);
    }
}
