using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
     public struct Item
    {
        public decimal price { get; set; }
        public string title { get; set; }
        public string options { get; set; }
    }
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public static ObservableCollection<Item> cart = new ObservableCollection<Item>();
        public static double subtotal;
        public static double tax;
        public static double tip;
        public MainWindow()
        {
            InitializeComponent();
            BeginOrderButton.Click += new RoutedEventHandler(Begin_Click);
            /*
            Item newItem = new Item();
            Item newItem2 = new Item();
            Item newItem3 = new Item();
            newItem.price = 100;
            newItem.title = "mocha test";
            newItem.options = "Milk" + " White Chocolate";
            newItem2.price = 100;
            newItem2.title = "mocha test2";
            newItem2.options = "Milk" + " White Chocolate";
            newItem3.price = 100;
            newItem3.title = "mocha test3";
            newItem3.options = "Milk" + " White Chocolate";
            cart.Add(newItem);
            cart.Add(newItem2);
            cart.Add(newItem3);*/
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new MainOrderPage());
        }
    }
}
