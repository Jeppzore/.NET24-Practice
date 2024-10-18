using System.ComponentModel;
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

namespace _6._Formulär_för_studenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            myListbox.Items.Add(new Student("Jesper", "Johansson", "jajo@iths.se"));
            myListbox.Items.Add(new Student("Kalle", "Karlsson", "kaka@iths.se"));
            myListbox.Items.Add(new Student("Morgania", "Morgansson", "momo@iths.se"));
            myListbox.Items.Add(new Student("Lucifer", "Lurvigsson", "lulu@iths.se"));

        }

        private void myListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            if (selectedStudent != null)
            {
                textboxFirst.Text = $"{selectedStudent.FirstName}";
                textboxLast.Text = $"{selectedStudent.LastName}";
                textboxEmail.Text = $"{selectedStudent.Email}";
                buttonRemove.IsEnabled = true;
            }
            else if (selectedStudent == null)
            {
                buttonRemove.IsEnabled = false;
                textboxFirst.Text = $" ";
                textboxLast.Text = $" ";
                textboxEmail.Text = $" ";
            }
        }

        private void textboxFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            if (selectedStudent != null)
            {
                selectedStudent.FirstName = textboxFirst.Text;
                RefreshListBox();           
                
            }
        }

        private void textboxLast_TextChanged(object sender, TextChangedEventArgs e)
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            if (selectedStudent != null)
            {
                selectedStudent.LastName = textboxLast.Text;
                RefreshListBox();
            }

        }

        private void textboxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            if (selectedStudent != null)
            {
                selectedStudent.Email = textboxEmail.Text;
                RefreshListBox();
            }

        }

        private void RefreshListBox()
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            myListbox.Items.Refresh();

            myListbox.SelectedItem = selectedStudent;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            myListbox.Items.Add(new Student(textboxFirst.Text, textboxLast.Text, textboxEmail.Text));
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            Student? selectedStudent = myListbox.SelectedItem as Student;

            if (selectedStudent != null)
            {
                myListbox.Items.Remove(selectedStudent);
            }
        }
    }


}