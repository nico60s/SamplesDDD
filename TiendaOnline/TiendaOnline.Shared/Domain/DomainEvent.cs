


namespace TiendaOnline.Shared.Domain
{
    public class DomainEvent : IDomainEvent
    {
        private readonly DateTime _occurredOn;
        private readonly Guid _id;
        public DomainEvent()
        {
            _id = Guid.NewGuid();
            _occurredOn = DateTime.Now;
        }
        public DateTime OccurredOn => _occurredOn;

        public Guid Id => _id;
    }
}
