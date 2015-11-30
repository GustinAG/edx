using System.Collections.Generic;
using System.Linq;

namespace RestaurantManager.UniversalWindows.BackEnd
{
    /// <summary>
    /// This is just a fake repository here.
    /// A real repository would be implemented significantly differently, of course.
    /// </summary>
    internal class MealsRepository
    {
        public IReadOnlyList<string> All { get; } = new[] { "Pizza", "Hamburger", "Hot-Dog", "Beer", "Wine", "Coke" }.ToList();
    }
}
