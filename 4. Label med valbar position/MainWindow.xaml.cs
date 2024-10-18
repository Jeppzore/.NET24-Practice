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

namespace _4._Label_med_valbar_position
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int x = 0;
        int y = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myLabelPosition.Content = $"x = {sliderX.Value.ToString("N0")} y = {sliderY.Value.ToString("N0")}";
        }

        private void sliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myLabelPosition.Content = $"x = {sliderX.Value.ToString("N0")} y = {sliderY.Value.ToString("N0")}";

        }
    }
}