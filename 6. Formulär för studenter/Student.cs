using System.ComponentModel;

namespace _6._Formulär_för_studenter
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Student(string firstname, string lastName, string email)
        {

            FirstName = firstname;
            LastName = lastName;
            Email = email;
            
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }

}