

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

// 4. Stegräknare
//Skapa en klass som kan användas som stegräknare. Den ska ha en property "Steps" som bara går att läsa;
//en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.

//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.


Person myPerson = new Person();
myPerson.FirstName = "Jesper"; //1.
myPerson.LastName = "Stranne"; //2.

Console.WriteLine($"{myPerson.FullName}");

Console.WriteLine("**** UPPGIFT 4 *****");

StepCounter myStepCounter = new StepCounter();

for ( int i = 0; i < 1010; i++ )
{
    myStepCounter.Step();
    Console.WriteLine($"{myStepCounter.Steps}");
}


class StepCounter
{
    private int _steps;
    public int Steps // Property Steps (Read-only)
    {
        get
        {
            return _steps;
        }
    }

    public void Step()
    {

        _steps++;

        if ( _steps == 1001 )
        {
            Reset();
        }
        
    }

    public void Reset()
    {
        _steps = 0;
        
        Console.WriteLine("RESET!");
    }
    
}

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


