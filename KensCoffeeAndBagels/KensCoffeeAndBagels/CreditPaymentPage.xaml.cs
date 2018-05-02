﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KensCoffeeAndBagels
{
    /// <summary>
    /// Interaction logic for CreditPaymentPage.xaml
    /// </summary>
    public partial class CreditPaymentPage : Page
    {
        public CreditPaymentPage()
        {
            InitializeComponent();
            OrderListBox.ItemsSource = MainWindow.cart;
            OrderListBox.DataContext = MainWindow.cart;
        }
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckOut());
        }

    }
}