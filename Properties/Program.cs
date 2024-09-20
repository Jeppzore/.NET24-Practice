

// 1. Person med property FirstName
//Skapa en klass "Person" som har en private field _firstName, och en public property FirstName.
//När man sätter värdet på FirstName ska detta sparas i _firstName,
//och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

// 2. Autoproperty LastName
//Lägg till en publik auto-property LastName som går att både läsa och skriva.

// 3. Read-only property FullName
// Lägg sedan till en publik property FullName som är read only (bara get;)
// När man läser av propertyn så ska den returnera hela namnet.
// Testa koden genom att skapa ett objekt, tilldela värden på både
// FirstName och LastName, och sedan skriva ut FullName.


Person myPerson = new Person();
myPerson.FirstName = "Jesper"; //1.
myPerson.LastName = "Stranne"; //2.

Console.WriteLine($"{myPerson.FullName}");

class Person
{
    private string _firstName; //1. private field

    public string FullName //3. public property med bara get (Read-only)
    {
        get
        {
            string _fullName = this.FirstName + " " + this.LastName;
            return _fullName;
        }
    }

    public string FirstName //1. public property
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value; //1. private field _firstName får värdet av FirstName
        }

    }

    public string LastName //2. public auto-property
    {
        get; set;
    }

}


