// ** LOOPAR **

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
Console.WriteLine();

Loopar006();
Console.WriteLine();

Loopar07();
Console.WriteLine();

//1. Skriv talen 20 till 30

static void Loopar01()
{
    for (int i = 20; i <= 30; i++)
    {
        Console.WriteLine(i);
    }
}

//2. Skriv ut alla jämna tal mellan 0 - 30 (0,2,4,6...)
static void Loopar02()
{
    for (int i = 0; i <= 30; i += 2)
    {
        Console.WriteLine(i);
    }
}

//3. Var tredje "Hej"
static void Loopar03()
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
static void Loopar04()
{
    Console.WriteLine("Skriv ett heltal: ");
    int tal1 = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++) //Multiplicerar tal1 tio gånger
    {
        int tal2 = (i * tal1);
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
static void Loopar05()
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
static void Loopar06()
{
    int aktuellRuta = 1, sistaRuta = 63;
    double risKorn = 1;

    Console.WriteLine("Ruta " + aktuellRuta + ":" + " " + risKorn + " riskorn");

    while (aktuellRuta <= sistaRuta)
    {
        risKorn *= 2;
        aktuellRuta++;

        Console.WriteLine("Ruta " + aktuellRuta + ":" + " " + risKorn + " riskorn");
    }
}

//6. Riskorn på Schackbräde - ALTERNATIV LÖSNING -
static void Loopar006()
{
    double rice = 1;

    for (int i = 1; i <= 64; i++)
    {
        Console.WriteLine($"Ruta {i}: {rice}");
        rice *=2;
    }
}

//7. Fylld box - WORK IN PROGRESS -- 

static void Loopar07()
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
