﻿using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RestaurantManager.UniversalWindows.Pages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            headerText.Text = Versioning.Title;
            versionText.Text = Versioning.Version;
        }
    }
}