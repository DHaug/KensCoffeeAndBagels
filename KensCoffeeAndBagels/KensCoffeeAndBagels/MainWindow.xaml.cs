using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace KensCoffeeAndBagels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
            BeginOrderButton.Click += new RoutedEventHandler(Begin_Click);
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new MainOrderPage());
        }
    }
}
