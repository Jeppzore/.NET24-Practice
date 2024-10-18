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

namespace _2._Räkna_upp_ochy_ner_i_en_label
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
        }
    }
}