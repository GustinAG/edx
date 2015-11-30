using System.Collections.Generic;
using System.Linq;

namespace RestaurantManager.Models.Repositories
{
    /// <summary>
    /// This is just a fake repository here.
    /// A real repository would be implemented significantly differently, of course.
    /// </summary>
    internal class MealsRepository
    {
        internal IReadOnlyList<string> All { get; }
            = new[]
            {
                "Pizza", "Hamburger", "Hot-Dog", "Steak", "Chicken", "Peas",
                "Rice", "Hummus", "Pita", "Beer", "Wine", "Coke"
            }.ToList();
    }
}
