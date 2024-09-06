//Labb01();
//Labb02();
//Labb03();
//Labb04();
//Labb05();
//labb06();
labb07();



//1. Bokstav för bokstav - fram till space
//Utgå från strängen (skapa en variabel med) "Hello World!", skriv ut hela strängen bokstav för bokstav,
//men avsluta när det kommer ett space. (Den ska alltså bara skriva “Hello”).

static void Labb01()
{
    string myString = "Hello World!";

    foreach (char c in myString)
    {
        Console.Write(c);

        if (c == ' ')
        {
            break;
        }
    }

}

//2. Bokstav för bokstav - radbyte på space
//Utgå från strängen "This is just some other text". Skriv ut strängen bokstav för bokstav,
//men när det kommer ett space, gör radbyte istället. (Du ska få ett ord på varje rad).
static void Labb02()
{
    string myString = "This is just some other text";

    foreach(char c in myString)
    {
        Console.Write(c);

        if (c == ' ')
        {
            Console.WriteLine();
        }
    }

}

//3. Bokstav för bokstav - varannan stjärna
//Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav.
//Men om index är en jämn siffra, skriv istället ut *
static void Labb03()
{
    int index = 0;
    string myString = "Detta är uppgift 3";

    foreach (char c in myString)
    {
        if (c != ' ')
        {
            if (index % 2 == 0)
            {
                Console.Write("*");
            }
        else 
            {
                Console.Write(c);
            }
        }
        else
        {
            Console.WriteLine(c);
        }
        index++;
    }
}

//4. Bokstav för bokstav - gröna o, röda l
// Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav.
// Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. Övriga bokstäver är vita/grå.

static void Labb04()
{
    string fras = "Hello world!";

    foreach (char c in fras)
    {
        
        if(c == 'o')
        {
            Console.ForegroundColor = (c == 'o' ? ConsoleColor.Green : ConsoleColor.Gray);
           
        }

        else if (c == 'l')
        {
            Console.ForegroundColor = (c == 'l' ? ConsoleColor.Red : ConsoleColor.Gray);
           
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.WriteLine(c);

    }
}
//5. Bokstav för bokstav - dubbla med grön färg
//Utgå från strängen "Hello world". Skriv ut bokstav för bokstav.
//Om två tecken på rad är samma så ska dessa vara grön färg.
//Övriga bokstäver är vita/grå.

static void Labb05()
{
    string myString = "Hello world!";

        for (int i = 0; i < myString.Length; i++)
        {

            if(i == myString.Length -1)
        {
            Console.Write(myString[i]);
            continue;
        }

            char nextChar = myString[i + 1];
            char currentChar = myString[i];


            if (nextChar == currentChar)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{currentChar}{nextChar}");
                i++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(myString[i]);
            }
        }

    
}

//.6 Bokstav för bokstav - grön substring
//Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", samt den mindre strängen "oo".
//Skriv ut den långa strängen bokstav för bokstav. Varje gång den mindre strängen förekommer (två 'o' på raken)
//så ska dessa vara med grön färg. Övriga bokstäver är vita/grå.

static void labb06()
{
    string myString1 = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

    for (int i = 0; i < myString1.Length; i++)
    {

        if (i == myString1.Length - 1)
        {
            Console.Write(myString1[i]);
            continue;
        }

        char nextChar = myString1[i + 1];
        char currentChar = myString1[i];


        if (nextChar == 'o' && currentChar == 'o')
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{currentChar}{nextChar}");
            i++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(myString1[i]);
        }

    }

}

//7. Bokstav för bokstav - grön substring 2
// Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo".
// D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.
static void labb07()
{
    string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

    for (int i = 0; i < myString.Length; i++)
    {

        if (i == myString.Length - 5)
        {
            Console.Write(myString[i]);
            continue;
        }

        char firstChar = myString[i];
        char secondChar = myString[i + 1];
        char thirdChar = myString[i + 2];
        char fourthChar = myString[i + 3];
        char fifthChar = myString[i + 4];


        if (firstChar == 'c' && secondChar == 'h' && thirdChar == 'u' && fourthChar == 'c' && fifthChar == 'k')
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{firstChar}{secondChar}{thirdChar}{fourthChar}{fifthChar}");
            i+= 5;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(myString[i]);
        }

    }
}