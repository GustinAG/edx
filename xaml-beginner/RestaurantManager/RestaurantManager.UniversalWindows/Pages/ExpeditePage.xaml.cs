using RestaurantManager.UniversalWindows.BackEnd;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class ExpeditePage : Page
    {
        private readonly IReadOnlyList<string> _orders;

        public ExpeditePage()
        {
            InitializeComponent();
            _orders = new OrdersRepository().All;
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            ordersView.ItemsSource = null;
        }
    }
}
