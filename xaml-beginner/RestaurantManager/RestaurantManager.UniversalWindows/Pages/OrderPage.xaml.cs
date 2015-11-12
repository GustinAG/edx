using RestaurantManager.UniversalWindows.BackEnd;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class OrderPage : Page
    {
        private readonly IReadOnlyList<string> _meals = MealsRepository.All;
        private readonly ObservableCollection<string> _orderedMeals = new ObservableCollection<string>();

        public OrderPage()
        {
            InitializeComponent();
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            _orderedMeals.Add(mealsBox.SelectedItem.ToString());
            mealsBox.SelectedItem = null;
        }

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            mealsBox.SelectedItem = null;
            _orderedMeals.Clear();
        }
    }
}
