
// ** ÖVNINGSUPPGIFTER **

//Indexering01();
//Indexering02();
//Indexering03();
//Indexering04();
//Indexering05();
//Indexering06();
//Indexering07();
Indexering08();

//Indexering10();


// 1. En bokstav på varje rad
//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.
static void Indexering01()
{
    Console.WriteLine("Skriv en sträng");
    string myString = Console.ReadLine();

    for (int i = 0; i < myString.Length; i++)
    {
        Console.WriteLine(myString[i]); //Indexering [] i myString (tar en char variabel i strängen myString)
    }

    Console.WriteLine("************");

    // Annat alternativ med foreach

    foreach (char c in myString)
    {
        Console.WriteLine(c);
    }

}

// 2. Siffror till Text
//Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
//Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.

static void Indexering02()
{
    Console.Write("Ange ett heltal mellan 0 och 9: ");
    string[] numbers = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
    int numberInput = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"{numbers [numberInput]}");
}

// 3. Baklänges
// Be användaren mata in en text. Skriv sedan ut texten baklänges.
static void Indexering03()
{
    Console.Write("Skriv något: ");
    string textInput = Console.ReadLine();
    
    // Lösning med både foreach och for loop

    foreach (char c in textInput.Reverse()) Console.Write(c);
    Console.WriteLine();
    for (int i = textInput.Length - 1; i >= 0; i--) Console.Write(textInput[i]);
}

//4. Dölj vokaler
//Ersätt vokaler med '*'
static void Indexering04()
{
    string vowels = "aAeEiIoOuUyYåÅäÄöÖ";
    Console.Write("Skriv en text; ");
    string input = Console.ReadLine();

    for (int i = 0; i < vowels.Length; i++)
    {
        input = input.Replace(vowels[i], '*');
    }
    Console.WriteLine(input);
    
}

//5. Palindrom
//Ett palindrom är ett ord som blir samma framlänges som baklänges.
//Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.
static void Indexering05()
{
    Console.Write("Skriv ett ord: ");
    string input = Console.ReadLine();

    if (input.ToLower().SequenceEqual(input.ToLower().Reverse()))
    {
        Console.Write("Ordet är ett palindrom!");
    }
    else
    {
        Console.Write("Ordet är INTE ett palindrom!");
    }

    /* ALTERNATIV LÖSNING
    Console.Write("Skriv ett ord: ");

    string input = Console.ReadLine();

    char[] reverse = input.ToCharArray();
    Array.Reverse(reverse);
    string reverseString = new string(reverse);

    if (reverseString.ToLower() == input.ToLower())
    {
        Console.WriteLine($"{input} är ett palindrom!");
    }
    else
    {
        Console.WriteLine($"{input} är inget palindrom då det blir {reverseString} baklänges!");
    }
    */
}

//.6 Miniräknare
//Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander. Till skillnad från uppgift 6
//i övningsuppgifter med variabler, så ska inmatningen nu ske på en rad (första talet, operator, andra talet).
//Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen "34 - 14", så ska programmet skriva ut "= 20".

static void Indexering06()
{
    Console.Write("Vad vill du räkna ut? 'x * y':");
    string input = Console.ReadLine();
    input = input.Replace(" ", "");

    if (input.Contains("+"))
    {
        string[] nummer = input.Split('+');
        int result = Int32.Parse(nummer[0]) + Int32.Parse(nummer[1]);
        Console.WriteLine($"{nummer[0]} + {nummer[1]} = {result}");
    }
    else if (input.Contains("-"))
    {
        string[] nummer = input.Split("-");
        int result = Int32.Parse(nummer[0]) - Int32.Parse(nummer[1]);
        Console.WriteLine($"{nummer[0]} - {nummer[1]} = {result}");
    }
    else if (input.Contains("*"))
    {
        string[] nummer = input.Split("*");
        int result = Int32.Parse(nummer[0]) - Int32.Parse(nummer[1]);
        Console.WriteLine($"{nummer[0]} * {nummer[1]} = {result}");
    }
    else if (input.Contains("/"))
    {
        string[] nummer = input.Split("/");
        int result = Int32.Parse(nummer[0]) - Int32.Parse(nummer[1]);
        Console.WriteLine($"{nummer[0]} / {nummer[1]} = {result}");
    }
    else
    {
        {
            Console.WriteLine("Fel inmatning, Försök igen!");
            Indexering06();
        }
    }
}
// 7. Omvänd ordning
// Be användaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord.
// Skriv sedan ut orden på skärmen i bakvänd ordning mot hur de matades in. Alltså ordet man
// skrev in sist, skrivs ut först.
static void Indexering07()
{
    Console.WriteLine("Mata in 7 ord: ");
    string[] ord = new string[7];

    //Console.WriteLine($"{ord[ordInput]}");

    for (int i = 0; i < 7; i++)
    {
        string ordInput = Console.ReadLine();
        ord[i] = ordInput;
    }
    Console.WriteLine("**********");

    for (int i = 6; i >= 0; i--)
    {
        Console.WriteLine(ord[i]);

        // Gammal kod som inte följer "DRY" - ersatt med ovan for-loop
        // Console.WriteLine($"{ord[6]} {ord[5]} {ord[4]} {ord[3]} {ord[2]} {ord[1]} {ord[0]}");
    }

    //8. Fördröjd utskrift
    // Skapa ett program som ber användaren att skriva in ett ord. Sedan ett till, och ett till i all evighet.
    // Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare.
    // Men om man inte skrivit in 10 ord än så kan den istället skriva just det: “Du har inte skrivit in 10 ord än.”
}

    static void Indexering08()
{
    List<string> ordlista = new List<string>();

    Console.WriteLine("Nu ska vi bygga en ordlista! (avsluta med ctrl + c");

    while (true)
    {
        Console.Write("Skriv ett ord: ");
        ordlista.Add(Console.ReadLine());
        if (ordlista.Count < 10)
        {
            Console.WriteLine("Du har inte skrivit in 10 ord än.");
        }
        else
        {
            Console.WriteLine(ordlista[ordlista.Count - 10]);
        }
    }

}


// 10. Färgade bokstäver 
static void Indexering10()
{
    Console.WriteLine("Hej! mata in en text");
    string fras = Console.ReadLine();

    Console.WriteLine("Skriv en bokstav som finns i det du nyss skrev.");
    char bokstav = Console.ReadLine()[0];
 
    foreach (char myChar in fras)
    {
        if (myChar == bokstav)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{myChar}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{myChar}");
        }
    }

}
