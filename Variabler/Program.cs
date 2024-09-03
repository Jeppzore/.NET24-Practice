
Variabler01();
Console.WriteLine();

Variabler02();
Console.WriteLine();

Variabler03();
Console.WriteLine();

Variabler04();
Console.WriteLine();

Variabler05();
Console.WriteLine();

Variabler06();
Console.WriteLine();

Variabler07();
Console.WriteLine();

//1. Hälsa på användaren
static void Variabler01()
{
    Console.WriteLine("Hej! " + "Vad heter du?");
    string användarNamn = Console.ReadLine();
    Console.WriteLine("Hej " + användarNamn);
}

//2. Multiplicera två tal
static void Variabler02()
{
    Console.WriteLine("Ange två heltal som du önskar multiplicera med varandra");

    int tal1 = Int32.Parse(Console.ReadLine());
    int tal2 = Int32.Parse(Console.ReadLine());
    int tal3 = tal1 * tal2;

    Console.WriteLine("Resultat: " + tal3);
}

//3. Verifiera Lösenord
static void Variabler03()
{
    string correctPassword = "abc123";
    Console.WriteLine("Vänligen ange korrekt lösenord: ");
    string guessPassword = (Console.ReadLine());

    if (correctPassword == guessPassword)
    {
        Console.WriteLine("Du har loggat in!");
    }
    else
    {
        Console.WriteLine("Fel lösenord!");
        Variabler03();
    }

}

//4. Jämför Tal
static void Variabler04()
{
    Console.WriteLine("Ange ett heltal");

    int tal = Int32.Parse(Console.ReadLine());

    if (tal < 100)
    {
        Console.WriteLine("Ditt tal är mindre än 100");
    }
    else if (tal == 100)
    {
        Console.WriteLine("Ditt tal är lika med 100");
    }
    else
    {
        Console.WriteLine("Ditt tal är större än 100");
    }
}

//5. Dubblera och halvera Tal
static void Variabler05()
{
    Console.WriteLine("Skriv in ett tal");
    double tal = Double.Parse(Console.ReadLine());

    Console.WriteLine("Hälften av " + tal + " = " + tal / 2 + " och det dubbla värdet av " + tal + " = " + tal * 2);
}

//6. Miniräknare
static void Variabler06()
{
    Console.WriteLine("DU ANVÄNDER NU JESPERS ADVANCERADE MINIRÄKNARE");
    Console.WriteLine("VÄNLIGEN ANGE ETT VALFRITT TAL");

    double tal1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Vänligen ange hur talet ska manipuleras: +, -, *, eller / ");

    char tecken = char.Parse(Console.ReadLine());

    if (tecken == '+')
    {
        Console.WriteLine("Vilket tal önskar du addera " + tal1 + " med? ");
        double tal2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Resultat: " + tal1 + " + " + tal2 + " = " + (tal1 + tal2));
        Variabler06();
    }
    else if (tecken == '-')
    {
        Console.WriteLine("Vilket tal önskar du subtrahera " + tal1 + " med? ");
        double tal2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Resultat: " + tal1 + " - " + tal2 + " = " + (tal1 - tal2));
        Variabler06();
    }
    else if (tecken == '*')
    {
        Console.WriteLine("Vilket tal önskar du multiplicera " + tal1 + " med? ");
        double tal2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Resultat: " + tal1 + " * " + tal2 + " = " + (tal1 * tal2));
        Variabler06();
    }
    else // Om tecken = '/'
    {
        Console.WriteLine("Vilket tal önskar du dividera " + tal1 + " med? ");
        double tal2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Resultat: " + tal1 + " / " + tal2 + " = " + (tal1 / tal2));
        Variabler06();
    }
}

//7. Summa och Medelvärde
static void Variabler07()
{
    double amountNumbers = 0;
    double totalSum = 0;

    while (true)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double parsedValue))
        {
            amountNumbers++;
            totalSum += parsedValue;
            Console.WriteLine(totalSum);
        }
        else
        {
            Console.WriteLine();
            double average = totalSum / amountNumbers;
            Console.WriteLine($"Average is {average}");
            break;
        }
    }
}
