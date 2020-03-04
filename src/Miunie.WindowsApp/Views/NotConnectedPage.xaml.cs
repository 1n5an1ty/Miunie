﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Miunie.WindowsApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NotConnectedPage : Page
    {
        public NotConnectedPage()
        {
            InitializeComponent();
        }

        private void ConfigBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SettingsPage), null);
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StatusPage), null);
        }
    }
}
