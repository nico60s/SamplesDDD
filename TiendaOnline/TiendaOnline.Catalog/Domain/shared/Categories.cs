namespace TiendaOnline.Catalog.Domain.shared
{
    public class Categories
    {
        private static string[] _categories = ["category1","category2"];
        internal static bool IsValid(string category) => _categories.Any(c => c == category);
    }
}
