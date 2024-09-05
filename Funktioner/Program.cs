//Funktioner01("Jesper", "Johansson");
//Funktioner02("Jesper" , "Alveberg");
//Funktioner03("Hejsan", 5);
Funktioner04();



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



