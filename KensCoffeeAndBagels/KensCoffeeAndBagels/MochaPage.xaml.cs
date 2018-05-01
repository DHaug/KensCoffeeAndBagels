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
            Add_To_.Click += new RoutedEventHandler(Add_Item_To_Cart);
        }

        private void Add_Item_To_Cart(object sender, RoutedEventArgs e)
        {
            Item newItem = new KensCoffeeAndBagels.Item();
            newItem.price = 10000; //Here you will want to calculate your price
            newItem.title = "Mocha";
            newItem.options = " 2% Milk" + "White Chocolate";
            MainWindow.cart.Add(newItem); //Here it is added to our global static list of our cart.
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainOrderPage());
        }

        private void Add_To__Click(object sender, RoutedEventArgs e)
        {
            /* Size Check */
            if (Size_S.IsChecked == true)
            {
                Test_Size.Content = "Size: Small";
            }
            else if (Size_M.IsChecked == true)
            {
                Test_Size.Content = "Size: Medium";
            }
            else
            {
                Test_Size.Content = "Size: Large";
            }

            /* Milk Check */
            if (Two.IsChecked == true)
            {
                Test_Milk.Content = "Milk: 2%";
            }
            else if (Whole.IsChecked == true)
            {
                Test_Milk.Content = "Milk: Whole";
            }
            else if (Nonfat.IsChecked == true)
            {
                Test_Milk.Content = "Milk: Nonfat";
            }
            else
            {
                Test_Milk.Content = "Milk: Soy";
            }

            /* Chocolate Check */
            if (White.IsChecked == true)
            {
                Test_Choco.Content = "Choco: White";
            }
            else if (Dark.IsChecked == true)
            {
                Test_Choco.Content = "Choco: Dark";
            }
            else
            {
                Test_Choco.Content = "Choco: Milk";
            }

            /* Caffination Check */
            if (Reg.IsChecked == true)
            {
                Test_Caff.Content = "Caff: Reg";
            }
            else if (Decaf.IsChecked == true)
            {
                Test_Caff.Content = "Caff: Decaf";
            }
            else
            {
                Test_Caff.Content = "Caff: Half";
            }
        }
    }
}
