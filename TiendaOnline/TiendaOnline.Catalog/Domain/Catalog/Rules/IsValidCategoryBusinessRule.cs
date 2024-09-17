

using TiendaOnline.Catalog.Domain.shared;
using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog.Rules
{
    public class IsValidCategoryBusinessRule : IBusinessRule
    {
        private readonly bool _isBroken;
        private readonly string _message;

        public IsValidCategoryBusinessRule(string category)
        {
            _isBroken = IsBrokenBusinessRule(category);
            _message = $"Business rule {GetType().Name} " +
                $"{_isBroken} broken.";
        }
        private static bool IsBrokenBusinessRule(string category)
        {
            return Categories.IsValid(category);
        }
        public bool IsBroken => _isBroken;

        public string Message => _message;
    }
}
