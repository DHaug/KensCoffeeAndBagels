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
    /// Interaction logic for CashPaymentPage.xaml
    /// </summary>
    public partial class CashPaymentPage : Page
    {
        NumberFormatInfo setPrecision = new NumberFormatInfo();

        public CashPaymentPage()
        {
            InitializeComponent();
            setPrecision.NumberDecimalDigits = 2;

            AddTip.Click += new RoutedEventHandler(UpdateTip);

            OrderListBox.ItemsSource = MainWindow.cart;
            OrderListBox.DataContext = MainWindow.cart;

            MainWindow.subtotal = 0;
            MainWindow.tax = 0;
            MainWindow.tip = 0;
            CalcTax();
            CalcTotal();
        }

        private void CalcTax()
        {
            for (int i = 0; i < MainWindow.cart.Count; i++)
            {
                MainWindow.subtotal += (double)MainWindow.cart[i].price;
            }
            MainWindow.tax = MainWindow.subtotal * 0.04;
            TaxValue.Text = "$" + MainWindow.tax.ToString("N", setPrecision);
        }

        private void CalcTotal()
        {
            MainWindow.subtotal = MainWindow.subtotal + MainWindow.tip + MainWindow.tax;
            SubtotalValue.Text = "$" + MainWindow.subtotal.ToString("N", setPrecision);
        }
        private void UpdateTip(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.subtotal -= MainWindow.tip;
                MainWindow.tip = Convert.ToDouble(TipAmount.Text);
                TipValue.Text = "$" + MainWindow.tip.ToString("N", setPrecision);
                MainWindow.subtotal += MainWindow.tip;
                SubtotalValue.Text = "$" + MainWindow.subtotal.ToString("N", setPrecision);
            }
            catch { }

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckOut());
        }
    }
}
