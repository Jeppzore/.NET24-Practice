using Microsoft.Win32;
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

namespace _3._App_för_att_öppna_och_visa_textfiler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string ?TextBox { get; }

        public MainWindow()
        {
            InitializeComponent();

        }


        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();

            if (result == true )
            {
                myTextBox.Text = System.IO.Path.GetFileName(dialog.FileName);
            }
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "File application", MessageBoxButton.YesNo);
            
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }

            return;

        }
    }
}