using Windows.UI.Xaml;
using RestaurantManager.Models;

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class ExpeditePage
    {
        public ExpeditePage()
        {
            InitializeComponent();
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            ((RestaurantModel)MainGrid.DataContext).Orders.Clear();
        }
    }
}
