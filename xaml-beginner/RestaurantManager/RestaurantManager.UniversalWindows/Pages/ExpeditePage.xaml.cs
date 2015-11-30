using Windows.UI.Xaml;

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
            OrdersView.ItemsSource = null;
        }
    }
}
