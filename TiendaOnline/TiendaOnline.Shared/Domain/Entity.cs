

namespace TiendaOnline.Shared.Domain
{
    public class Entity<T>(T id) : IEntity<T>
    {
        private readonly T _id = id;

        public T Id => _id;
        protected void CheckRule(IBusinessRule rule) 
        {
            if (rule.IsBroken)
            {
                throw new BusinessRuleException(rule);
            }
        }
    }
}
