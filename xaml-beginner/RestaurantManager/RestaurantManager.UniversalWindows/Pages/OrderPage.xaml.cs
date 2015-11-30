using Windows.UI.Xaml;
using RestaurantManager.Models;

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class OrderPage
    {
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
            if (MealsBox.SelectedItem == null) return;

            ((RestaurantModel)MainGrid.DataContext).CurrentOrderMeals.Add(MealsBox.SelectedItem.ToString());
            MealsBox.SelectedItem = null;
        }

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            MealsBox.SelectedItem = null;
            ((RestaurantModel)MainGrid.DataContext).CurrentOrderMeals.Clear();
        }
    }
}
