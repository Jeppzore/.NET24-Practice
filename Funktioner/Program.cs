//Funktioner01("Jesper", "Johansson");
Funktioner02("Jesper" , "Alveberg");


// 1. Slå ihop för- och efternamn - skriv ut
//Skriv en funktion som tar två parametrar: firstName och lastName. Funktionen ska skriva ut hela namnet på skärmen.
//Testa genom att anropa funktionen med ditt namn.
static void Funktioner01(string firstName, string lastName)
{
    Console.WriteLine($"Hej, mitt namn är: {firstName} {lastName}");

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




