
using System.Runtime.CompilerServices;

Person person1 = new Person { firstName = "Greger", lastName = "Johansson" };
Person person2 = new Person { firstName = "Lukas", lastName = "Börjesson" };

Console.WriteLine($"Namnet på person 1 är: {person1.firstName} {person1.lastName}");
Console.WriteLine($"Namnet på person 2 är: {person2.firstName} {person2.lastName}");

Console.WriteLine($"Person1 namn baklänges är: {person1.GetFullNameReversed()}");
Console.WriteLine($"Person2 namn med titel är: {person2.GetFullName("Mr.")}");

// 5. Lägg till så personer kan ha föräldrar.
//Uppdatera person-klassen så att varje person kan ha en mamma och en pappa.
//Dessa representeras som publika fält(fields) av typen Person
//(eller vad du kallade klassen i uppgift 1).

class Person
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string fullName = "Default name";

    public string GetFullName() // Returnerar hela namnet
    {
        fullName = this.firstName + " " + this.lastName;
        return fullName;
    }

    public string GetFullName(string title) // Returnerar hela namnet med inmatad string-titeln först
    {
        GetFullName();
        title = title + " " + this.fullName;
        return title;
    }

    public string GetFullNameReversed() // Returnerar hela namnet baklänges
    {
        char[] fullName = this.GetFullName().ToCharArray();
        Array.Reverse( fullName );
        this.fullName = new string (fullName);

        return this.fullName;
    }

}


// 1. Skriva ut namn på personer
// Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName.
// Skapa två instanser av personer med olika för och efternamn,
// och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.

// 2. Lägg till en metod som returnerar hela namnet
// Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.


// 3. Lägg till en metod som returnerar namnet baklänges
//Uppdatera klassen med en ny metod: public string GetFullNameReversed()
//som returnerar en sträng med hela namnet baklänges. Låt denna metoden använda sig av metoden i uppgift 2.

// 4. Overload av GetFullName med titel.
// GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2;
// och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr."
// som returnerar namnet på personen med titeln framför.

// 5. Lägg till så att personer kan ha föräldrar.
//Uppdatera person-klassen så att varje person kan ha en mamma och en pappa.
//Dessa representeras som publika fält(fields) av typen Person
//(eller vad du kallade klassen i uppgift 1).

