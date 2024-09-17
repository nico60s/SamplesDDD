

namespace TiendaOnline.Shared.Domain
{
    public class Entity<T> 
        
    {
        private readonly T _id;
        public T Id => _id;

        public Entity(T id) => _id = id;

        protected void CheckRule(IBusinessRule rule) 
        {
            if (rule.IsBroken)
            {
                throw new BusinessRuleException(rule);
            }
        }
    }
}
