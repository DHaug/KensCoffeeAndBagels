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
    /// Interaction logic for LattePage.xaml
    /// </summary>
    public partial class LattePage : Page
    {
        double small = 1.20;
        double medium = 1.40;
        double large = 1.60;



        public LattePage()
        {
            InitializeComponent();

            //These handle LIVE changes to our cart list for auto-updating
            CartListBox.ItemsSource = MainWindow.cart;
            CartListBox.DataContext = MainWindow.cart;

            Remove_item.Click += new RoutedEventHandler(Delete_Item);
            Add_To_.Click += new RoutedEventHandler(AddItem);
            Back_Button.Click += new RoutedEventHandler(GoBack);
            Complete_Order.Click += new RoutedEventHandler(CompleteOrder);

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



            //Handle special options

            if (Sweetner.SelectedIndex > 0)
            {
                price += Sweetner.SelectedIndex * .5;
                newItem.options += "Sweetner: " + Sweetner.SelectedIndex.ToString() + ", ";
            }

            if (Sauces.SelectedIndex > 0)
            {
                price += Sauces.SelectedIndex * .5;
                newItem.options += "Sauces: " + Sauces.SelectedIndex.ToString() + ", ";
            }

            if (Creamer.SelectedIndex > 0)
            {
                price += Creamer.SelectedIndex * .5;
                newItem.options += "Creamer: " + Creamer.SelectedIndex.ToString() + "/4 Ounces, ";
            }

            if (Syrup.SelectedIndex > 0)
            {
                price += Syrup.SelectedIndex * .5;
                newItem.options += "Syrup: " + Syrup.SelectedIndex.ToString() + ", ";
            }

            if (PowderNew.SelectedIndex > 0)
            {
                price += PowderNew.SelectedIndex * .5;
                newItem.options += "Powder: " + PowderNew.SelectedIndex.ToString() + ", ";
            }

            if (Shots.SelectedIndex > 0)
            {
                price += Shots.SelectedIndex * .5;
                newItem.options += "Syrup: " + Syrup.SelectedIndex.ToString() + ", ";
            }

            if (Syrup.SelectedIndex > 0)
            {
                price += Syrup.SelectedIndex * .5;
                newItem.options += "Shots: " + Shots.SelectedIndex.ToString() + ", ";
            }

            if (Drizzle.SelectedIndex > 0)
            {
                price += Drizzle.SelectedIndex * .5;
                newItem.options += "Drizzle: " + Drizzle.SelectedIndex.ToString() + ", ";
            }

            if (Foam.SelectedIndex > 0)
            {
                price += Foam.SelectedIndex * .5;
                newItem.options += "Foam: " + Foam.SelectedIndex.ToString() + ", ";
            }

            if (WhippedCream.SelectedIndex > 0)
            {
                price += WhippedCream.SelectedIndex * .5;
                newItem.options += "Whipped Chream: " + WhippedCream.SelectedIndex.ToString() + ", ";
            }

            newItem.price = (decimal)price;
            newItem.title = "Latte";

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
