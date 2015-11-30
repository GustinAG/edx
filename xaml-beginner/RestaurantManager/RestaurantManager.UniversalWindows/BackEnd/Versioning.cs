using System.Reflection;

namespace RestaurantManager.UniversalWindows.BackEnd
{
    internal class Versioning
    {
        public static string Version { get; } = typeof(Versioning).GetTypeInfo().Assembly.GetName().Version.ToString();
    }
}
