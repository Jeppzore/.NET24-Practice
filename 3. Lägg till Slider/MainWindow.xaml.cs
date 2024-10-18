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

namespace _3._Lägg_till_Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int value = 5;

        public MainWindow()
        {
            InitializeComponent();
            mySlider.Value = value;

        }

        private void buttonIncrease_Click(object sender, RoutedEventArgs e)
        {

            if (value >= 9)
            {
                return;
            }

            else if (value < 10)
            {
                value++;
            }

            myLabel.Content = value;
            mySlider.Value = value;
        }

        private void buttonDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (value <= 0)
            {
                return;
            }

            else if (value > 0)
            {
                value--;
            }

            myLabel.Content = value;
            mySlider.Value = value;
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myLabel.Content = mySlider.Value.ToString("N0");
            value = (int)mySlider.Value;
        }
    }
}