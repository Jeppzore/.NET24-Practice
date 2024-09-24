
//6. Vattenglas
// Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, och en metod för att tömma glaset.
// Dessutom ska den ha en private field som håller reda på om glaset är tomt eller fullt. Beroende på tillståndet (tomt/fullt)
// så ska metoden som fyller glaset skriva ut antingen “Fyller glaset” eller “Glaset är redan fullt”.
// Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

WaterGlass glass1 = new WaterGlass() { IsEmpty = true, IsBroken = false, Name = "Glas 1" };
glass1.BreakMyGlass();
glass1.EmptyMyGlass();
glass1.FillMyGlass();

Console.WriteLine();

WaterGlass glass2 = new WaterGlass() { IsEmpty = false, IsBroken = false, Name = "Glas 2" };
glass2.FillMyGlass();
glass2.BreakMyGlass();
glass2.EmptyMyGlass();

class WaterGlass
{

    private bool _isEmpty;
    private bool _isBroken;
    public string Name;

    public bool IsEmpty
    {
        get
        {
            return _isEmpty;
        }
        set
        {
            _isEmpty = value;
        }

    }

    public bool IsBroken
    {
        get
        {
            return _isBroken;
        }
        set
        {
            _isBroken = value;
        }

    }

    public void FillMyGlass() // Metod för att fylla på glaset om det inte redan är fullt
    {
        if (this.IsEmpty == true && this.IsBroken == false)
        {
            Console.WriteLine($"Fyller på {this.Name}");
            this.IsEmpty = false;
        }

        if (this.IsEmpty == false && this.IsBroken == false)
        {
            Console.WriteLine($"{this.Name} är redan fullt!");
        }

        if (this.IsBroken == true)
        {
            Console.WriteLine($"{this.Name} kan inte fyllas då det är trasigt");
        }
    }

    public void EmptyMyGlass() // Metod för att tömma glaset om det inte redan är tomt
    {
        if (this.IsEmpty == false && this.IsBroken == false)
        {
            Console.WriteLine($"Tömmer {this.Name}");
            this.IsEmpty = true;
        }

        if (this.IsEmpty == true && this.IsBroken == false)
        {
            Console.WriteLine($"{this.Name} är redan tomt!");
        }

        if (this.IsBroken == true)
        {
            Console.WriteLine($"{this.Name} kan inte tömmas då det redan är trasigt");
        }
    }

    public void BreakMyGlass() // Metod för att förstöra glaset och ändra värdet på IsBroken till objektet som kallar på metoden.
    {
        this.IsBroken = true;

        if (this.IsEmpty == true)
        {
            Console.WriteLine($"{this.Name} gick sönder men inget vatten spilldes då det var tomt");
        }
        if (this.IsEmpty == false)
        {
            Console.WriteLine($"{this.Name} gick sönder och vattnet spilldes på golvet");
        }
    }

}












//********* START PÅ UPPGIFT 5 *************
/*
Car volvo = new Car("Volvo xc60", 250000, "White");

Car tesla = new Car("Tesla Roadster", 500000, "Black");

Car Ford = new Car() {Model = "Ford Focus", Price = 70000, Color = "Blue" };
Ford.Halfprice();
Console.WriteLine($"Your car is a {Ford.Model.ToUpper()} with a price of {Ford.Price} kr, and color {Ford.Color.ToUpper()}");

class Car
{

    private string _model;
    private int _price;
    private string _color;

    public Car() // Konstruktor
    {

    }

    public Car(string Model, int Price, string Color) // Overload Konstruktor
    {
        this._model = Model;
        this._price = Price;
        this._color = Color;

        this.Halfprice();
        Console.WriteLine($"Your car is a {this.Model.ToUpper()} with a price of {this.Price} kr, and color {this.Color.ToUpper()}");
        Console.WriteLine();
    }

    public string Model // property Model som returnerar värdet på private field _model
    {
        get
        {
            return _model;
        }
        set
        {
            _model = value;
        }
    }

    public int Price // property Price som returnerar värdet på private field _price
    {

        get
        {
            return _price;
        }
        set
        {
            _price = value;
        }

    }

    public string Color // property Color som returnerar värdet på private field _color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }

    public void Halfprice()
    {
        this._price = this._price / 2;
    }

} //********* SLUT PÅ UPPGIFT 5 *************
*/

/*Person myPerson = new Person();
myPerson.FirstName = "Jesper"; //1.
myPerson.LastName = "Stranne"; //2.

Console.WriteLine($"{myPerson.FullName}");

Console.WriteLine("**** UPPGIFT 4 *****");

StepCounter myStepCounter = new StepCounter();

for ( int i = 0; i < 1000; i++ )
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

*/


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

//5. Bil
// Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
// Skapa publika properties för att hämta eller ändra värdet på varje field.
//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?
//Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.