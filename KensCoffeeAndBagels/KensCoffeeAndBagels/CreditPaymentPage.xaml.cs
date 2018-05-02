using System;
using System.Collections.Generic;
using System.Globalization;
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
        NumberFormatInfo setPrecision = new NumberFormatInfo();
        public static double subtotal;
        public static double tax;
        double tip;


        public CreditPaymentPage()
        {
           
            InitializeComponent();

            setPrecision.NumberDecimalDigits = 2;

            AddTip.Click += new RoutedEventHandler(UpdateTip);
            ContinueButton.Click += new RoutedEventHandler(Continue_Click);

            OrderListBox.ItemsSource = MainWindow.cart;
            OrderListBox.DataContext = MainWindow.cart;

            CalcTax();
            CalcTotal();
        }

        private void CalcTax()
        {
            for (int i = 0; i < MainWindow.cart.Count; i++)
            {
                subtotal += (double)MainWindow.cart[i].price;
            }
            tax = subtotal * 0.04;
            TaxValue.Text = "$" + tax.ToString("N", setPrecision);
        }

        private void CalcTotal()
        {
            subtotal = subtotal + tip + tax;   
            SubtotalValue.Text = "$" + subtotal.ToString("N", setPrecision);
        }
        private void UpdateTip(object sender, RoutedEventArgs e)
        {
            try
            {
                subtotal -= tip;
                tip = Convert.ToDouble(TipAmount.Text);
                TipValue.Text = "$" + tip.ToString("N", setPrecision);
                subtotal += tip;
                SubtotalValue.Text = "$" + subtotal.ToString("N", setPrecision);
            } catch { }
            
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentVerification());
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckOut());
        }

    }
}
