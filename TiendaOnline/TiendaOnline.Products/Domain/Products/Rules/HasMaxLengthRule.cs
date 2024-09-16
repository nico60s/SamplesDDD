

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Products.Domain.Products.Rules
{
    public class HasMaxLengthRule : IBusinessRule
    {
        private readonly bool _isBroken;
        private readonly string _message;
        
        
        public HasMaxLengthRule(string stringValue, int maxLength)
        {
            _isBroken = RuleIsBroken(stringValue, maxLength);
        
        }
        private static bool RuleIsBroken(string value, int maxLength)
        {
            return value.Length > maxLength;
        }
        public bool IsBroken => _isBroken;
        public string Message => _message;
    }
}
