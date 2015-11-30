using System.Collections.Generic;
using System.Collections.ObjectModel;
using RestaurantManager.Models.Repositories;

namespace RestaurantManager.Models
{
    public class RestaurantModel
    {
        public RestaurantModel()
        {
            Meals = new MealsRepository().All;
            Orders = new ObservableCollection<string>(new OrdersRepository().All);
            CurrentOrderMeals = new ObservableCollection<string>();
        }

        public IReadOnlyList<string> Meals { get; private set; }
        public ObservableCollection<string> Orders { get; private set; }
        public ObservableCollection<string> CurrentOrderMeals { get; private set; }
    }
}
