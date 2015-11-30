using System.Reflection;

namespace RestaurantManager.Models
{
    public class Versioning
    {
        public static string Version { get; } = typeof(Versioning).GetTypeInfo().Assembly.GetName().Version.ToString();
    }
}
