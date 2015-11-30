using System.Collections.ObjectModel;
using Windows.UI.Xaml;

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class OrderPage
    {
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
            if (MealsBox.SelectedItem == null) return;

            _orderedMeals.Add(MealsBox.SelectedItem.ToString());
            MealsBox.SelectedItem = null;
        }

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            MealsBox.SelectedItem = null;
            _orderedMeals.Clear();
        }
    }
}
