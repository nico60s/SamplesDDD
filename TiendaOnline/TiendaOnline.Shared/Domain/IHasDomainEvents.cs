
namespace TiendaOnline.Shared.Domain
{
    public interface IHasDomainEvents
    {
        IReadOnlyCollection<IDomainEvent> Events { get; }
    }
}
