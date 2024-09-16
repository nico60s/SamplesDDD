


namespace TiendaOnline.Shared.Domain
{
    public class IdValueObject : ValueObject
    {
        public Guid Value { get; }
        protected IdValueObject(Guid id) => Value = id;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
