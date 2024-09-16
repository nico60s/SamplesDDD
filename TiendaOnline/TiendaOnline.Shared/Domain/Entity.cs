

namespace TiendaOnline.Shared.Domain
{
    public class Entity : IEntity<IdValueObject>
        
    {
        private readonly IdValueObject _id;
        public IdValueObject Id => throw new NotImplementedException();

        public Entity(IdValueObject id) => id = _id;

        protected void CheckRule(IBusinessRule rule) 
        {
            if (rule.IsBroken)
            {
                throw new BusinessRuleException(rule);
            }
        }
    }
}
