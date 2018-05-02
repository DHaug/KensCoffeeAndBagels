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
    /// Interaction logic for CheckOut.xaml
    /// </summary>
    public partial class CheckOut : Page
    {
        public CheckOut()
        {
            InitializeComponent();

            //This is where we handle the click events. Reference the button name and send it to a function
            CreditButton.Click += new RoutedEventHandler(Credit_Click);

            //These Buttons have been linked to a function but not a navigation because there is no page built yet for them
            CashButton.Click += new RoutedEventHandler(Cash_Click);
            AppleButton.Click += new RoutedEventHandler(Apple_Click);
            GiftCardButton.Click += new RoutedEventHandler(GiftCard_Click);
            SamsungButton.Click += new RoutedEventHandler(Samsung_Click);
            DebitButton.Click += new RoutedEventHandler(Debit_Click);

            OrderListBox.ItemsSource = MainWindow.cart;
            OrderListBox.DataContext = MainWindow.cart;
        }

        private void Debit_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Samsung_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GiftCard_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Apple_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Credit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreditPaymentPage());
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainOrderPage());
        }

    }
}
