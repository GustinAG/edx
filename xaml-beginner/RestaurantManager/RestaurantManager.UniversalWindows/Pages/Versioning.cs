using System.Reflection;

namespace RestaurantManager.UniversalWindows.Pages
{
    internal static class Versioning
    {
        private static readonly Assembly _assembly = typeof(Versioning).GetTypeInfo().Assembly;

        internal static readonly string Version = _assembly.GetName().Version.ToString();
        internal static readonly string Title = _assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
    }
}
