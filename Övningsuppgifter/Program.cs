
// ** ÖVNINGSUPPGIFTER **

// ***** METODERNA ******

/*
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

Loopar01();
Console.WriteLine();

Loopar02();
Console.WriteLine();

Loopar03();
Console.WriteLine();

Loopar04();
Console.WriteLine();

Loopar05();
Console.WriteLine();

Loopar06();
Console.WriteLine();*/

Loopar07();
Console.WriteLine();

// ***********  SLUT PÅ METODER  ************************


//1. Hälsa på användaren
void Variabler01()
{
    Console.WriteLine("Hej! " + "Vad heter du?");
    string användarNamn = Console.ReadLine();
    Console.WriteLine("Hej " + användarNamn);
}
//2. Multiplicera två tal
void Variabler02()
{
    Console.WriteLine("Ange två heltal som du önskar multiplicera med varandra");

    int tal1 = Int32.Parse(Console.ReadLine());
    int tal2 = Int32.Parse(Console.ReadLine());
    int tal3 = tal1 * tal2;

    Console.WriteLine("Resultat: " + tal3);
}
//3. Verifiera Lösenord
void Variabler03()
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
void Variabler04()
{
    Console.WriteLine("Ange ett heltal");

    int tal = Int32.Parse(Console.ReadLine());

    if( tal < 100 )
    {
        Console.WriteLine("Ditt tal är mindre än 100");
    }
    else if( tal == 100)
    {
        Console.WriteLine("Ditt tal är lika med 100");
    }
    else
    {
        Console.WriteLine("Ditt tal är större än 100");
    }
}

//5. Dubblera och halvera Tal
void Variabler05()
{
    Console.WriteLine("Skriv in ett tal");
    double tal = Double.Parse(Console.ReadLine());

    Console.WriteLine("Hälften av " + tal + " = " + tal / 2 + " och det dubbla värdet av " + tal + " = " + tal * 2);
}

//6. Miniräknare
void Variabler06()
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
/*void Variabler07()
{
    Console.WriteLine("Skriv ett tal: ");

    bool resultat;
    double tal;
    int i = 0;
    string angettTal = Console.ReadLine();
    resultat = double.TryParse(angettTal, out tal);

    while (resultat == true)
    {
        Console.WriteLine();
        i++;
    }

    Console.WriteLine(i);
}*/

// ** END OF VARIABLER **

// ** LOOPAR **

//1. Skriv talen 20 till 30

void Loopar01()
{
    for (int i = 20; i <= 30; i++)
    {
        Console.WriteLine(i);
    }
}

//2. Skriv ut alla jämna tal mellan 0 - 30 (0,2,4,6...)
void Loopar02()
{
    for (int i = 0 ; i <= 30; i+=2)
    {
        Console.WriteLine(i);
    }
}

//3. Var tredje "Hej"
void Loopar03()
{
    for (int i = 0; i <= 30; i++)
    {
        if (i % 3 == 0) 
        {
            Console.WriteLine("Hej");
        }

        Console.WriteLine(i);
    }
}

//4. Gångertabell
void Loopar04()
{
    Console.WriteLine("Skriv ett heltal: ");
    int tal1 = int.Parse(Console.ReadLine());

    for (int i = 1 ;i <= 10; i++) //Multiplicerar tal1 tio gånger
    {
        int tal2 = (i*tal1);
        Console.WriteLine(i + " * " + tal1 + " = " + tal2); // Matar ut värdet av i multiplicerat med tal1
    }
}

/*Array exempel som adderar samtliga nummer med varandra
*****
int[] numbers = { 1, 2, 3, 4, 5,};
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum: " + sum);
*/

//5. Summa
void Loopar05()
{
    int tal1 = 0, tal2 = 999;
    int sum = 0;

    while (tal1 <= tal2)
    {
        tal1++;
        sum = tal1 + sum;
    }

    Console.WriteLine("Total summa: " + sum);
}

//6. Riskorn på Schackbräde
void Loopar06()
{
    int aktuellRuta = 1, sistaRuta = 64;
    double risKorn = 1;
    Console.WriteLine("Ruta " + aktuellRuta + ":" + " " + risKorn + " riskorn");

    while (aktuellRuta <= sistaRuta)
    {
        risKorn *= 2;
        aktuellRuta++;

        Console.WriteLine("Ruta " + aktuellRuta + ":" + " " + risKorn + " riskorn");
    }

    Console.WriteLine("Total summa: " + risKorn);
}

//7. Fylld box - WORK IN PROGRESS -- 

void Loopar07()
{

    int i = 0;

    Console.WriteLine("Ange höjd: ");
    double höjd = Double.Parse(Console.ReadLine());

    Console.WriteLine("Ange bredd: "); 
    double bredd = Double.Parse(Console.ReadLine());

    char boxHöjd = 'X';
    char boxBredd = 'X';

    while (i < höjd)
    {
        i++;

        if (i == höjd)
        {
            Console.WriteLine($"{boxHöjd} {höjd}");
        }

    }

    //Console.WriteLine(boxHöjd * höjd);
    //Console.WriteLine(boxBredd * bredd);
}
