//Funktioner01("Jesper", "Johansson");
//Funktioner02("Jesper" , "Alveberg");
//Funktioner03("Hejsan", 5);
//Funktioner04();
//Funktioner05();
//Funktioner06();
//Funktioner07();
//Funktioner08();
//Funktioner10();
//Funktioner11();
Funktioner12();


// 1. Slå ihop för- och efternamn - skriv ut
//Skriv en funktion som tar två parametrar: firstName och lastName. Funktionen ska skriva ut hela namnet på skärmen.
//Testa genom att anropa funktionen med ditt namn.
static void Funktioner01(string firstName, string lastName)
{

    Console.WriteLine($"Hej, mitt namn är: {firstName} {lastName}");

    firstName = "Pontus";
    lastName = "Johansson";

    Console.WriteLine($"{firstName} {lastName}");

}

// 2. Slå ihop för- och efternamn - returnera
// Skriv om funktionen ovan så att den istället för att skriva ut namnet returnerar
// en string med hela namnet. Anropa funktionen och skriv ut returvärdet.

 static string Funktioner02(string firstName, string lastName)
{

    string fullName = firstName + lastName;
    Console.WriteLine(fullName);
    return fullName;
}

//3. Kolla om strängen är längre än ett givet antal tecken.
//Skriv en funktion som tar in en sträng och ett heltal. Om längden på strängen är större än heltalet returnera true, annars false.

static bool Funktioner03(string myString, int myInt)
{
    int i = 0;
    myString = "hejsan";
    myInt = 5;

    foreach (char c in myString)
    {
        i++;

        if (i > myInt)
        {
            Console.WriteLine(true);
            return true;
        }
    }

    Console.WriteLine(false);
    return false;


    /*
    static bool LengthCheck(string input, int length) => (input.Length > length);

    Console.WriteLine($"Är \"Kristoffer\" längre än 5 tecken? {LengthCheck("Kristoffer", 5)}");
    */
}

//4. Omvandla Celsius till Fahrenheit
// Skriv en funktion som översätter ett värde från Celsius till Fahrenheit. Både in-parameter och returvärde ska vara av datatyp double.

static void Funktioner04()
{
    static double CelciusToFahrenheit(double celcius) => (celcius * 1.8) + 32;

    Console.WriteLine($"20 celcius är {CelciusToFahrenheit(20)} fahrenheit");
    Console.WriteLine($"40.3 celcius är {CelciusToFahrenheit(40.3)} fahrenheit");
    Console.WriteLine($"-20.5 celcius är {CelciusToFahrenheit(-20.5)} fahrenheit");
   
}

//5. Gör ett bindestreck mellan varje karaktär i name
static void Funktioner05()
{

    Lines("Jesper"); // Kallar på metoden Lines med en parameter för string name

    static string Lines(string name)
    {

        name.ToCharArray(); // Omvandlar string till en char array innehållandes alla bokstäver

        foreach (char c in name)
        {
            Console.Write(c);
            Console.Write("-");
        }

        return name;
    }
}

//6. Egen version av String.Join();
static void Funktioner06()
{
    static string MyJoin(string joiner, params string[] inputs)
    {
        string joinedString = "";
        for (int i = 0; i < inputs.Length; i++)
        {
            joinedString += (i != inputs.Length - 1) ? inputs[i] + joiner : inputs[i];
        }
        return joinedString;
    }

    Console.WriteLine(MyJoin("->", "Jesper", "Axel", "Mikael", "Alveberg", "Johansson"));
    Console.WriteLine(MyJoin(" <-> ", "Jag", "kanske", "kan", "skriva", "koden", "lite", "enklare"));
}

static void Funktioner07()
{

    static double MiddleValue(int[] value)
    {
        double sum = 0;
        foreach(int number in value) 
        {
            sum += number;
        }
        return sum / value.Length;
    }

    Console.WriteLine($"Medelvärdet är: {MiddleValue([10, 9, 3, 20, -2])}");

}

//8. Siffror till text
// Skriv en funktion som tar ett heltal in, och returnerar en string[]
// där varje element innehåller ordet för varje siffra i talet.
static void Funktioner08()
{

    static string[] DigitToWords(int number)
    {
        // Array med ord för varje siffra
        string[] digitWords = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", };

        // Konverterar talet till en sträng för att enkelt iterera över varje siffra
        string numberToString = number.ToString();
        string[] result = new string[numberToString.Length];

        // För varje siffra, hämta motsvarande ord
        for(int i = 0; i < numberToString.Length; i++)
        {
            int digit = int.Parse(numberToString[i].ToString());
            result[i] = digitWords[digit];
        }

        return result;
    }

    int number = 12345; // Exempel på ett tal

    // Anropa funktionen och få tillbaka strängarrayen
    string[] words = DigitToWords(number);

    // skriv ut varje element
    foreach (string word in words) 
    {
        Console.Write(word + " ");    
    }

    Console.WriteLine(); // Ny rad efter utskrift

}

// 10. Hitta index för alla förekomster av ett givet tecken
// Skapa funktionen int[] IndexesOf(string text, char c) som
// söker igenom strängen text och returnerar en int[] med index
// till alla förekomster av c i text.

static void Funktioner10()
{

    static int[] IndexesOf(string text, char c)
    {
        // Lista för att lagra alla index där tecknet förekommer
        List<int> indexes = new List<int>();

        // Loopa igenom varje tecken i strängen
        for (int i = 0; i < text.Length; i++)
        {
            // Om tecknet vid index (i) matchar det vi letar efter, lägg till index i listan
            if (text[i] == c)
            {
                indexes.Add(i);
            }
        }
        
        // Konvertera listan till en array och returnera den
        return indexes.ToArray();
    }

    string text = "programmering är roligt"; // Exempelsträng
    char c = 'r'; // Tecknet vi letar efter

    // Anropa funktionen och få tillbaka arrayen med index
    int[] indexes = IndexesOf(text, c);

    // Skriv ut varje index
    Console.WriteLine("Tecknet '{0}' hittades på index:", c);
    foreach (int index in indexes)
    {
        Console.WriteLine(index);
    }


}

// 11. Kasta tärning
// Skriv en funktion ThrowDice() som returnerar ett slumpmässigt heltal 1-6.
// Skriv en annan funktion ThrowMultipleDice(int n) som returnerar resultatet av att man slagit n tärningar.

static void Funktioner11()
{
    Random randSides = new Random();
    Random randBigSides = new Random();

    Console.WriteLine("Normdal Dice");
    Console.WriteLine(ThrowDice(1));
    Console.WriteLine(ThrowDice(2));

    Console.WriteLine();

    Console.WriteLine("Big Dice:");
    Console.WriteLine(ThrowBigDice(1,24));
    Console.WriteLine(ThrowBigDice(1,24));
    Console.WriteLine(ThrowBigDice(1,24));


    int ThrowDice(int diceThrows)
    {

        int result = diceThrows *= randSides.Next(1, 7);
        return result;

    }

    int ThrowBigDice(int diceThrows, int sidesPerDice)
    {

        int result = diceThrows *= randBigSides.Next(1, sidesPerDice);
        return result;

    }

}

static void Funktioner12()
{


}

