using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5._Gemensam_slider_för_position
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderXY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (checkboxX.IsChecked == true && checkboxY.IsChecked == false)
            {
                myLabelPositionY.Content = $"y = {sliderXY.Value.ToString("N0")}";
            }

            else if (checkboxY.IsChecked == true && checkboxX.IsChecked == false)
            {
                myLabelPositionX.Content = $"x = {sliderXY.Value.ToString("N0")}";
            }

            else if(checkboxX.IsChecked == false && checkboxY.IsChecked == false)
            {
                myLabelPositionX.Content = $"x = {sliderXY.Value.ToString("N0")}";
                myLabelPositionY.Content = $"y = {sliderXY.Value.ToString("N0")}";
            }
        }   
    }
}