
namespace TiendaOnline.Shared.Domain
{
    public interface IEntity<T>
    {
        T Id { get; }
    }
}
