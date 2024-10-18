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

namespace _8._Formulär_för_studenter
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

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (textboxFirst.Text.Length > 0 && textboxLast.Text.Length > 0 && textboxEmail.Text.Length > 0)
            {
                MessageBox.Show($"Ny student: \n Förnamn: {textboxFirst.Text} \n Efternamn: {textboxLast.Text} \n Email: {textboxEmail.Text}");
                myListbox.Items.Add($"{textboxFirst.Text} {textboxLast.Text}   |   {textboxEmail.Text}");
                textboxFirst.Clear();
                textboxLast.Clear();
                textboxEmail.Clear();          
            }
        }
    }
}