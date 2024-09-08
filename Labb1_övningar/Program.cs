//Labb01();
//Labb02();
//Labb03();
//Labb04();
//Labb05();
//labb06();
//Labb07();
//Labb08();
Labb09();




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
    string myString1 = "How much wood would a woodchuck chuck if a woodchuck could chuck wood??";

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

static void Labb07()
{

    string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    string storedString = string.Empty;

    for (int i = 0; i < userInput.Length; i++)
    {
        storedString += userInput[i];
        if (storedString.Contains("chuck"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(storedString);
            storedString = string.Empty;
        }
        else if (storedString.Contains(" ") || i == userInput.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(storedString);
            storedString = string.Empty;
        }

    }

    //**********************TIDIGARE NOTES***************************//

    //string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    //string newString = myString.Substring(26, 5); //newString får värdet "chuck"
    //string[] chuck = new string[4]; //Lagrar alla "chuck" i myString

    /*string myString1 = "How much wood would a woodchuck chuck if a woodchuck could chuck wood??";

    for (int i = 0; i < myString1.Length; i++)
    {

        if (i == myString1.Length - 4)
        {
            Console.Write($"{myString1[i]}{myString1[i + 1]}{myString1[i + 2]}{myString1[i +3 ]} ");
            break;
        }

        char firstChar = myString1[i];
        char secondChar = myString1[i + 1];
        char thirdChar = myString1[i + 2];
        char fourthChar = myString1[i + 3];
        char fifthChar = myString1[i + 4];

        if (firstChar == 'c' && secondChar == 'h' && thirdChar == 'u' && fourthChar == 'c' && fifthChar == 'k')
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{firstChar}{secondChar}{thirdChar}{fourthChar}{fifthChar}");
            i+=4;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(myString1[i]);
        }


    }*/

    //**********************TIDIGARE NOTES***************************//

}

//8.Bokstav för bokstav - grön substring 3
//Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen,
//alltså valfri text som ska sökas (färgas grön) i den längre texten.
static void Labb08()
{
    Console.WriteLine("Ange en bokstav eller ord ur texten: How much wood would a woodchuck chuck if a woodchuck could chuck wood?");
    string userInput = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    string storedString = string.Empty;
    string userInput2 = Console.ReadLine();

    for (int i = 0; i < userInput.Length; i++)
    {
        storedString += userInput[i];
        if (storedString.Contains(userInput2))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(storedString);
            storedString = string.Empty;
        }
        else if (storedString.Contains(" ") || i == userInput.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(storedString);
            storedString = string.Empty;
        }

    }
}

//.9 Bokstavspyramid
//Utgå från strängen "Hello world!". Gör ett program som skriver ut första bokstaven en gång på första raden.
//Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. Alltså:
//H
//ee
//lll
//... etc

//Behöver ha en loop(j) i en loop (i) som plusar med 1 för varje storedString som skrivs ut och skriver ut den senaste storedString * värdet på j

static void Labb09()
{
    string myString = "Hello world!";
    string storedString = string.Empty;

    for (int i = 0; i < myString.Length; i++)
    {
        storedString += myString[i];
        for (int j = 0; j < storedString.Length; j++) 
        
        {
            Console.Write(storedString[i]);
        }
        Console.WriteLine();

    }
}

