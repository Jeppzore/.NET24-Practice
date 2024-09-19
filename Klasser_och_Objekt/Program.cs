//*** NOTERINGAR **** ///


//Person person1 = new Person { firstName = "Greger", lastName = "Johansson" };
//Person person2 = new Person { firstName = "Lukas", lastName = "Börjesson" };

//Console.WriteLine($"Namnet på person 1 är: {person1.firstName} {person1.lastName}");
//Console.WriteLine($"Namnet på person 2 är: {person2.firstName} {person2.lastName}");

//Console.WriteLine($"Person1 namn baklänges är: {person1.GetFullNameReversed()}");
//Console.WriteLine($"Person2 namn med titel är: {person2.GetFullName("Mr.")}");

//6.
Person myself = new Person();
myself.firstName = "Jesper";
myself.lastName = "Stranne";

Person mother = new Person();
mother.firstName = "Lena";
mother.lastName = "Johansson";

myself.mother = mother;

Person father = new Person();
father.firstName = "Mikael";
father.lastName = "Alveberg";

myself.father = father;

Console.WriteLine($"Mitt namn är: {myself.GetFullName()}");
Console.WriteLine($"Min mammas namn är: {myself.mother.GetFullName()}");
Console.WriteLine($"Min pappas namn är: {myself.father.GetFullName()}");
Console.WriteLine("**********");
Console.WriteLine(myself.GetSelfAndParents());


class Person
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string fullName = "Default name";

    // Varje Person kan ha två referenser till Person-Objekt (father, mother)
    public Person father;
    public Person mother;

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

    //7.
    // Lägg till en public string GetSelfAndParents() som returnerar en sträng på formatet
    // "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". Om mammans eller pappans namn
    // saknas (null) markera det med "okänd" i strängen. Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"
    public string GetSelfAndParents()
    {
        // ??
        // If mamma är null = skriv ut mammans namn som null
        //

        return $"{this.GetFullName()} - Mamma: {this.mother.GetFullName()} - Pappa: {this.father.GetFullName()}";

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

// 6. Skapa ett objekt som representerar dig och dina föräldrar
// Gör en instans av en person och ge den ditt för- och efternamn.
// Lägg även in dina föräldrars namn, kopplade till dig. Så t.ex myself.GetFullName()
// returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.

// 7. 
// Lägg till en public string GetSelfAndParents() som returnerar en sträng på formatet
// "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". Om mammans eller pappans namn
// saknas (null) markera det med "okänd" i strängen. Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"