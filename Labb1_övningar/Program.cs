//Labb01();
//Labb02();
//Labb03();
//Labb04();
using System.Drawing;
using System.Text;

//Labb05();
Labb005();



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
    string myString = "Hello world";

    foreach (char c in myString) 
    {

        if (myString[2] == myString[3])
        {
            Console.ForegroundColor = (c == 'l' ? ConsoleColor.Green : ConsoleColor.Gray);
            
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;     
        }

        Console.Write(c);

    }
}

static void Labb005()
{
    string myString = "Hello world";

        for (int i = 0; i < myString.Length-1; i++)
        {
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