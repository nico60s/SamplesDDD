
namespace TiendaOnline.Shared.Domain
{
    public interface IEntity<T>
        where T : ValueObject
    {
        T Id { get; }
    }
}
