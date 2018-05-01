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
    /// Interaction logic for FrozenDrinkPage.xaml
    /// </summary>
    public partial class FrozenDrinkPage : Page
    {
        public enum SmoothieType { SB, TB, MB, MA, CV, DA};
        public SmoothieType smoothie;

        public FrozenDrinkPage()
        {
            smoothie = SmoothieType.SB; //Default Smoothie Type
            InitializeComponent();

            /* Hides all components until option is selected */
            /* Size Block */
            this.Size_Con.Visibility  = Visibility.Hidden;
            this.Size.Visibility      = Visibility.Hidden;
            this.Size_S.Visibility    = Visibility.Hidden;
            this.Size_M.Visibility    = Visibility.Hidden;
            this.Size_L.Visibility    = Visibility.Hidden;

            /* Milk Block */
            this.Milk_Con.Visibility  = Visibility.Hidden;
            this.Milk.Visibility      = Visibility.Hidden;
            this.Two.Visibility       = Visibility.Hidden;
            this.Whole.Visibility     = Visibility.Hidden;
            this.Nonfat.Visibility    = Visibility.Hidden;
            this.Soy.Visibility       = Visibility.Hidden;

            /* Smoothie Block */
            this.Smooth_SB.Visibility = Visibility.Hidden;
            this.Smooth_TB.Visibility = Visibility.Hidden;
            this.Smooth_MB.Visibility = Visibility.Hidden;
            this.Smooth_MA.Visibility = Visibility.Hidden;
            this.Smooth_CV.Visibility = Visibility.Hidden;
            this.Smooth_DA.Visibility = Visibility.Hidden;

            /* Other */
            this.Comments.Visibility  = Visibility.Hidden;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainOrderPage());
        }

        private void Smoothie_Click(object sender, RoutedEventArgs e)
        {
            Smoothie.Background = Brushes.PaleTurquoise;
            /* Hides all components until option is selected */
            /* Size Block */
            this.Size_Con.Visibility  = Visibility.Visible;
            this.Size.Visibility      = Visibility.Visible;
            this.Size_S.Visibility    = Visibility.Visible;
            this.Size_M.Visibility    = Visibility.Visible;
            this.Size_L.Visibility    = Visibility.Visible;

            /* Milk Block */
            this.Milk_Con.Visibility  = Visibility.Visible;
            this.Milk.Visibility      = Visibility.Visible;
            this.Two.Visibility       = Visibility.Visible;
            this.Whole.Visibility     = Visibility.Visible;
            this.Nonfat.Visibility    = Visibility.Visible;
            this.Soy.Visibility       = Visibility.Visible;

            /* Smoothie Block */
            this.Smooth_SB.Visibility = Visibility.Visible;
            this.Smooth_TB.Visibility = Visibility.Visible;
            this.Smooth_MB.Visibility = Visibility.Visible;
            this.Smooth_MA.Visibility = Visibility.Visible;
            this.Smooth_CV.Visibility = Visibility.Visible;
            this.Smooth_DA.Visibility = Visibility.Visible;

            /* Other */
            this.Comments.Visibility  = Visibility.Visible;
        }

        private void Smooth_SB_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.SB;
            Smooth_SB.Background = Brushes.PaleTurquoise;
            Smooth_TB.Background = Brushes.LightGray;
            Smooth_MB.Background = Brushes.LightGray;
            Smooth_MA.Background = Brushes.LightGray;
            Smooth_CV.Background = Brushes.LightGray;
            Smooth_DA.Background = Brushes.LightGray;
        }
        private void Smooth_TB_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.TB;
            Smooth_SB.Background = Brushes.LightGray;
            Smooth_TB.Background = Brushes.PaleTurquoise;
            Smooth_MB.Background = Brushes.LightGray;
            Smooth_MA.Background = Brushes.LightGray;
            Smooth_CV.Background = Brushes.LightGray;
            Smooth_DA.Background = Brushes.LightGray;
        }
        private void Smooth_MB_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.MB;
            Smooth_SB.Background = Brushes.LightGray;
            Smooth_TB.Background = Brushes.LightGray;
            Smooth_MB.Background = Brushes.PaleTurquoise;
            Smooth_MA.Background = Brushes.LightGray;
            Smooth_CV.Background = Brushes.LightGray;
            Smooth_DA.Background = Brushes.LightGray;
        }
        private void Smooth_MA_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.MA;
            Smooth_SB.Background = Brushes.LightGray;
            Smooth_TB.Background = Brushes.LightGray;
            Smooth_MB.Background = Brushes.LightGray;
            Smooth_MA.Background = Brushes.PaleTurquoise;
            Smooth_CV.Background = Brushes.LightGray;
            Smooth_DA.Background = Brushes.LightGray;
        }
        private void Smooth_CV_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.CV;
            Smooth_SB.Background = Brushes.LightGray;
            Smooth_TB.Background = Brushes.LightGray;
            Smooth_MB.Background = Brushes.LightGray;
            Smooth_MA.Background = Brushes.LightGray;
            Smooth_CV.Background = Brushes.PaleTurquoise;
            Smooth_DA.Background = Brushes.LightGray;
        }
        private void Smooth_DA_Click(object sender, RoutedEventArgs e)
        {
            smoothie = SmoothieType.DA;
            Smooth_SB.Background = Brushes.LightGray;
            Smooth_TB.Background = Brushes.LightGray;
            Smooth_MB.Background = Brushes.LightGray;
            Smooth_MA.Background = Brushes.LightGray;
            Smooth_CV.Background = Brushes.LightGray;
            Smooth_DA.Background = Brushes.PaleTurquoise;
        }

        private void Add_To_Click(object sender, RoutedEventArgs e)
        {
            switch (smoothie)
            {
                case SmoothieType.SB:
                    Test_Label.Content = "Strawberry Banana";
                    break;
                case SmoothieType.TB:
                    Test_Label.Content = "Tropic Berry";
                    break;
                case SmoothieType.MB:
                    Test_Label.Content = "Mixed Berry";
                    break;
                case SmoothieType.MA:
                    Test_Label.Content = "Mango Acai";
                    break;
                case SmoothieType.CV:
                    Test_Label.Content = "Cherry Vanilla";
                    break;
                case SmoothieType.DA:
                    Test_Label.Content = "Daily Smoothie";
                    break;
            }
            if(Size_S.IsChecked == true)
            {
                Test_Size.Content = "Size: Small";
            }
            else if(Size_M.IsChecked == true)
            {
                Test_Size.Content = "Size: Medium";
            }
            else
            {
                Test_Size.Content = "Size: Large";
            }

            if (Two.IsChecked == true)
            {
                Test_Milk.Content = "Milk: 2%";
            }
            else if (Whole.IsChecked == true)
            {
                Test_Milk.Content = "Milk: Whole";
            }
            else if(Nonfat.IsChecked == true)
            {
                Test_Milk.Content = "Milk: Nonfat";
            }
            else
            {
                Test_Milk.Content = "Milk: Soy";
            }
            //NavigationService.Navigate(new MainOrderPage());
        }
    }
}
