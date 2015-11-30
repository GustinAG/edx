using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.Models.Repositories
{
    /// <summary>
    /// This is just a fake repository here.
    /// A real repository would be implemented significantly differently, of course.
    /// </summary>
    internal class OrdersRepository
    {
        private const int MaxOrderCount = 20;
        private const int MaxMealPerOrderCount = 8;

        private readonly IReadOnlyList<string> _meals = new MealsRepository().All;
        private readonly Random _random = new Random(DateTime.Now.Millisecond);

        internal OrdersRepository()
        {
            Init();
        }

        internal IReadOnlyList<string> All { get; private set; }

        private void Init()
        {
            var orders = new List<string>();

            for (int i = 0; i < Random(MaxOrderCount); i++)
            {
                var builder = new StringBuilder();

                for (int j = 0; j < Random(MaxMealPerOrderCount); j++) builder.AppendLine(_meals[Random(_meals.Count) - 1]);

                orders.Add(builder.ToString());
            }

            All = orders;
        }

        private int Random(int max)
        {
            return _random.Next(1, max);
        }
    }
}
