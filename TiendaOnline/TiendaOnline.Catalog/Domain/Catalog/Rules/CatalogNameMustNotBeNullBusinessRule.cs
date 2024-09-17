

using TiendaOnline.Shared.Domain;

namespace TiendaOnline.Catalog.Domain.Catalog.Rules
{
    internal class CatalogNameMustNotBeNullBusinessRule : IBusinessRule
    {
        private readonly bool _isBroken;
        private readonly string _name;
        public CatalogNameMustNotBeNullBusinessRule(string catalogName)
        {
              _isBroken = IsNullOrEmptyCatalogName(catalogName);
            _name = catalogName;
        }
        private static bool IsNullOrEmptyCatalogName(string catalogName)
        {
            return string.IsNullOrEmpty(catalogName);
        }
        public bool IsBroken => _isBroken;

        public string Message => $"catalog name has no value .{_name} ";
    }
}
