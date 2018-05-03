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
    /// Interaction logic for PaymentVerification.xaml
    /// </summary>
    public partial class PaymentVerification : Page
    {
        NumberFormatInfo setPrecision = new NumberFormatInfo();
        public PaymentVerification(double subtotal)
        {
            setPrecision.NumberDecimalDigits = 2;
            InitializeComponent();

            NoButton.Click += new RoutedEventHandler(NoButton_Click);
            YesButton.Click += new RoutedEventHandler(YesButton_Click);

            TotalText.Text += MainWindow.subtotal.ToString("N", setPrecision);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cart.Clear();
            MainWindow.subtotal = 0;
            MainWindow.tax = 0;
            NavigationService.Navigate(new MainWindow());
            
        }
    }
}
