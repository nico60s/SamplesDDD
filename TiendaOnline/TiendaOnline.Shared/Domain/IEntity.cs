
namespace TiendaOnline.Shared.Domain
{
    public interface IEntity<T>
        where T: IdValueObject
    {
        T Id { get; }
    }
}
