using System.Reflection;

namespace RestaurantManager.UniversalWindows.BackEnd
{
    internal static class Versioning
    {
        internal static readonly string Version = typeof(Versioning).GetTypeInfo().Assembly.GetName().Version.ToString();
    }
}
