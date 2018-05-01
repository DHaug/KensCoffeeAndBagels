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
    /// Interaction logic for MainOrderPage.xaml
    /// </summary>
    public partial class MainOrderPage : Page
    {
        public MainOrderPage()
        {
            InitializeComponent();
            
            //This is where we handle the click events. Reference the button name and send it to a function
            MochaButton.Click += new RoutedEventHandler(Mocha_Click);
            FrozenDrinksButton.Click += new RoutedEventHandler(Frozen_Click);

            //These Buttons have been linked to a function but not a navigation because there is no page built yet for them
            TeaButton.Click += new RoutedEventHandler(Tea_Click);
            BlackCoffeeButton.Click += new RoutedEventHandler(BlackCoffee_Click);
            SpecialtyButton.Click += new RoutedEventHandler(Specialty_Click);
            SeasonalButton.Click += new RoutedEventHandler(Seasonal_Click);
            BlendedButton.Click += new RoutedEventHandler(Blended_Click);
            LatteButton.Click += new RoutedEventHandler(Latte_Click);
            DeleteEntryInListbox.Click += new RoutedEventHandler(Delete_Item);

            //These handle LIVE changes to our cart list for auto-updating
            CartListBox.ItemsSource = MainWindow.cart;
            CartListBox.DataContext = MainWindow.cart;


        }


        //Allows user to remove from the cart. We only need to remove from cart because our listbox auto-updates with it
        private void Delete_Item(object sender, RoutedEventArgs e)
        {
            if (CartListBox.SelectedIndex >= 0)
            {
                MainWindow.cart.RemoveAt(CartListBox.SelectedIndex);
            }
        }

        //Navigation has been set for these
        private void Frozen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FrozenDrinkPage());
        }

        private void Mocha_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MochaPage());
        }


        //Navigation still needs to be set once we create a page for these. 
        private void Blended_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Latte_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Seasonal_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Specialty_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BlackCoffee_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
