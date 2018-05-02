using System;
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
using System.Windows.Shapes;

namespace KensCoffeeAndBagels
{
    /// <summary>
    /// Interaction logic for MochaPage.xaml
    /// </summary>
    public partial class MochaPage : Page
    {
        public MochaPage()
        {
            InitializeComponent();
            CartListBox.ItemsSource = MainWindow.cart;
            CartListBox.DataContext = MainWindow.cart;
        }

        private void Add_Item_To_Cart(object sender, RoutedEventArgs e)
        {
            //Item newItem = new KensCoffeeAndBagels.Item();
            //newItem.price = 10000; //Here you will want to calculate your price
            //newItem.title = "Mocha";
            //newItem.options = " 2% Milk" + "White Chocolate";
            //MainWindow.cart.Add(newItem); //Here it is added to our global static list of our cart.
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainOrderPage());
        }

        private void Add_To__Click(object sender, RoutedEventArgs e)
        {
            double price = 2.67;
            Item newItem = new Item();

            string BoxString = (Flavor_1.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString1 = (Flavor_2.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString2 = (Flavor_3.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString3 = (Flavor_4.SelectedItem as ComboBoxItem).Content.ToString();

            switch (BoxString)
            {
                case "Vanilla":
                    newItem.options += "Flavor 1: Vanilla ";
                    break;
                case "Caramel":
                    newItem.options += "Flavor 1: Caramel ";
                    break;
                case "Mint":
                    newItem.options += "Flavor 1: Mint ";
                    break;
                case "None":
                    break;
                default:
                    break;
            }
            switch (BoxString1)
            {
                case "Vanilla":
                    newItem.options += "Flavor 2: Vanilla ";
                    break;
                case "Caramel":
                    newItem.options += "Flavor 2: Caramel ";
                    break;
                case "Mint":
                    newItem.options += "Flavor 2: Mint ";
                    break;
                case "None":
                    break;
                default:
                    break;
            }
            switch (BoxString2)
            {
                case "Vanilla":
                    newItem.options += "Flavor 3: Vanilla ";
                    break;
                case "Caramel":
                    newItem.options += "Flavor 3: Caramel ";
                    break;
                case "Mint":
                    newItem.options += "Flavor 3: Mint ";
                    break;
                case "None":
                    break;
                default:
                    break;
            }
            switch (BoxString3)
            {
                case "Vanilla":
                    newItem.options += "Flavor 4: Vanilla ";
                    break;                     
                case "Caramel":                
                    newItem.options += "Flavor 4: Caramel ";
                    break;                     
                case "Mint":                   
                    newItem.options += "Flavor 4: Mint ";
                    break;
                case "None":
                    break;
                default:
                    break;
            }

            if (Chocolate_Check.IsChecked == true)
            {
                newItem.options += "Chocolate ";
            }
            if (Espresso_Check.IsChecked == true)
            {
                newItem.options += "Espresso ";
            }
            if (Whip_Check.IsChecked == true)
            {
                newItem.options += "Whipped Creme ";
            }

            price += Additions();

            newItem.price = (decimal)price;
            newItem.title = "Mocha";

            MainWindow.cart.Add(newItem);
        }
        private double Additions()
        {
            double price = 0.0;
            string BoxString = (Flavor_1.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString1 = (Flavor_2.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString2 = (Flavor_3.SelectedItem as ComboBoxItem).Content.ToString();
            string BoxString3 = (Flavor_4.SelectedItem as ComboBoxItem).Content.ToString();

            switch (BoxString)
            {
                case "Vanilla":
                    price += 0.2;
                    break;
                case "Caramel":
                    price += 0.3;
                    break;
                case "Mint":
                    price += 0.5;
                    break;
                case "None":
                    price += 0.0;
                    break;
                default:
                    price += 0.0;
                    break;
            }
            switch (BoxString1)
            {
                case "Vanilla":
                    price += 0.2;
                    break;
                case "Caramel":
                    price += 0.3;
                    break;
                case "Mint":
                    price += 0.5;
                    break;
                case "None":
                    price += 0.0;
                    break;
                default:
                    price += 0.0;
                    break;
            }
            switch (BoxString2)
            {
                case "Vanilla":
                    price += 0.2;
                    break;
                case "Caramel":
                    price += 0.3;
                    break;
                case "Mint":
                    price += 0.5;
                    break;
                case "None":
                    price += 0.0;
                    break;
                default:
                    price += 0.0;
                    break;
            }
            switch (BoxString3)
            {
                case "Vanilla":
                    price += 0.2;
                    break;
                case "Caramel":
                    price += 0.3;
                    break;
                case "Mint":
                    price += 0.5;
                    break;
                case "None":
                    price += 0.0;
                    break;
                default:
                    price += 0.0;
                    break;
            }

            if(Chocolate_Check.IsChecked == true)
            {
                price += 0.3;
            }
            else
            {
                price += 0.0;
            }
            if (Espresso_Check.IsChecked == true)
            {
                price += 0.4;
            }
            else
            {
                price += 0.0;
            }
            if (Whip_Check.IsChecked == true)
            {
                price += 0.2;
            }
            else
            {
                price += 0.0;
            }

            return price;
        }

        private void Remove_item_Click(object sender, RoutedEventArgs e)
        {
            if (CartListBox.SelectedIndex >= 0)
            {
                MainWindow.cart.RemoveAt(CartListBox.SelectedIndex);
            }
        }

        private void Complete_Order_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckOut());
        }
    }
}
