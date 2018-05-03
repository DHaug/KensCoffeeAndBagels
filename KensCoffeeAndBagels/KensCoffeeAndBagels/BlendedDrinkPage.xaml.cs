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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KensCoffeeAndBagels
{
    /// <summary>
    /// Interaction logic for BlendedDrinkPage.xaml
    /// </summary>
    public partial class BlendedDrinkPage : Page
    {
        double small = 2.20;
        double medium = 2.99;
        double large = 3.30;



        public BlendedDrinkPage()
        {
            InitializeComponent();

            //These handle LIVE changes to our cart list for auto-updating
            CartListBox.ItemsSource = MainWindow.cart;
            CartListBox.DataContext = MainWindow.cart;

            Remove_item.Click += new RoutedEventHandler(Delete_Item);
            Add_To_.Click += new RoutedEventHandler(AddItem);
            Back_Button.Click += new RoutedEventHandler(GoBack);
            Complete_Order.Click += new RoutedEventHandler(CompleteOrder);
            Complete_Order.IsEnabled = false;
            Remove_item.IsEnabled = false;
        }

        private void CompleteOrder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckOut());
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        //Allows user to remove from the cart. We only need to remove from cart because our listbox auto-updates with it
        private void Delete_Item(object sender, RoutedEventArgs e)
        {
            if (CartListBox.SelectedIndex >= 0)
            {
                MainWindow.cart.RemoveAt(CartListBox.SelectedIndex);
            }
        }

        private void Dark_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void None_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void AddItem(object sender, RoutedEventArgs e)
        {
            double price = 0;
            Item newItem = new Item();

            price += getCaffinationPrice();
            price += getSizePrice();
            price += getRoastPrice();
            price += getMilkPrice();

            Complete_Order.IsEnabled = true;
            Remove_item.IsEnabled = true;

            //Handle special options

            if (Sweetner.SelectedIndex > 0)
            {
                newItem.options += "Sweetner: " + Sweetner.SelectionBoxItem.ToString() + ", ";
            }

            if (Sauces.SelectedIndex > 0)
            {
                price += .3;
                newItem.options += "Sauces: " + Sauces.SelectionBoxItem.ToString() + ", ";
            }

            if (Creamer.SelectedIndex > 0)
            {
                price += Creamer.SelectedIndex * .3;
                newItem.options += "Creamer: " + Creamer.SelectionBoxItem.ToString() + ", ";
            }

            if (Syrup.SelectedIndex > 0)
            {
                price += .3;
                newItem.options += "Syrup: " + Syrup.SelectionBoxItem.ToString() + ", ";
            }

            if (PowderNew.SelectedIndex > 0)
            {
                price += .3;
                newItem.options += "Powder: " + PowderNew.SelectionBoxItem.ToString() + ", ";
            }

            if (Shots.SelectedIndex > 0)
            {
                price += Shots.SelectedIndex * .3;
                newItem.options += "Syrup: " + Syrup.SelectionBoxItem.ToString() + ", ";
            }

            if (Syrup.SelectedIndex > 0)
            {
                price += .3;
                newItem.options += "Shots: " + Shots.SelectionBoxItem.ToString() + ", ";
            }

            if (Drizzle.SelectedIndex > 0)
            {
                price += .3;
                newItem.options += "Drizzle: " + Drizzle.SelectionBoxItem.ToString() + ", ";
            }

            if (Foam.SelectedIndex > 0)
            {
                price += Foam.SelectedIndex * .3;
                newItem.options += "Foam: " + Foam.SelectionBoxItem.ToString() + ", ";
            }

            if (WhippedCream.SelectedIndex > 0)
            {
                price += WhippedCream.SelectedIndex * .5;
                newItem.options += "Whipped Chream: " + WhippedCream.SelectionBoxItem.ToString() + ", ";
            }

            newItem.price = (decimal)price;
            newItem.title = LatteType.SelectionBoxItem.ToString();

            MainWindow.cart.Add(newItem);


        }

        private double getRoastPrice()
        {
            double price = 0;

            if (MediumBrown.IsChecked == true)
            {
                price = .20;
            }
            else if (DarkBrown.IsChecked == true)
            {
                price = .40;
            }

            return price;
        }

        private double getMilkPrice()
        {
            double price = 0;

            if (NoneMilk.IsChecked == true)
            {
                price = 0;
            }
            else if (Whole.IsChecked == true)
            {
                price = .10;
            }
            else if (Nonfat.IsChecked == true)
            {
                price = .30;
            }
            else if (Two.IsChecked == true)
            {
                price = .10;
            }

            return price;
        }

        private double getSizePrice()
        {
            double price = 0;

            if (Size_S.IsChecked == true)
            {
                price = small;
            }
            else if (Size_M.IsChecked == true)
            {
                price = medium;
            }
            else if (Size_L.IsChecked == true)
            {
                price = large;
            }

            return price;
        }

        private double getCaffinationPrice()
        {
            double price = 0;

            if (Decaf.IsChecked == true)
            {
                price = .10;
            }
            else if (Reg.IsChecked == true)
            {
                price = 0;
            }
            else if (Half.IsChecked == true)
            {
                price = .5;
            }

            return price;
        }

        private void CartListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
