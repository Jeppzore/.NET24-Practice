//Labb01();
//Labb02();
//Labb03();
//Labb04();
//Labb05();
//labb06();
//Labb07();
//Labb08();
//Labb09();
//Labb10();
//Labb11();
//Labb12();
//Labb13();
Labb14();
//Labb15();




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

    for (int i = 0; i < myString.Length; i++)
    {
        for (int j = 0; j <= i; j++) 
        
        {
            Console.Write(myString[i]);
        }
        Console.WriteLine();
    }
}

//10. Ordpyramid
//Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
//Gör ett program som skriver ut första ordet en gång på första raden; andra ordet två gånger på nästa rad.
//Tredje ordet tre gånger på nästa. etc. alltså:
static void Labb10()
{
    try
    {
    string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    string storedString = string.Empty;
    string[] myStringWords = myString.Split(' ');

    for (int i = 0; i < myStringWords.Length; i++)
    {
        storedString = myStringWords[i];
        for (int j = 0;j <= i; j++)
        {
            Console.Write($"{storedString}");
        }

        Console.WriteLine();
    }

    }
    catch(Exception ex)
    {
        Console.WriteLine($"Något fel inträffade: {ex.Message}");
    }
}

//11. Ordpyramid 2
//Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
//Gör ett program som på första raden skriver ut första ordet. På nästa rad skriver ut de två första orden,
//sedan de tre första orden på nästa rad o.s.v till man kommit till raden som skriver ut hela meningen. Alltså:
//How
//How much
//How much wood
//... etc

static void Labb11()
{
    try
    {
        string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
        string storedString = string.Empty;
        string[] myStringWords = myString.Split(' ');

        for (int i = 0; i < myStringWords.Length; i++)
        {

            for (int j = 0; j <= i; j++)
            {
                storedString = myStringWords[j];
                Console.Write($"{storedString} ");
            }

            Console.WriteLine();
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Något fel inträffade: {ex.Message}");
    }
}

//12. Rödmarkerade ord
//Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad.
//På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött.
//På tredje raden ska tredje vara rött osv. Alltså:
//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//How much wood would a woodchuck chuck if a woodchuck could chuck wood?
//... etc
static void Labb12()
{
    try
    {
        string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
        string[] myStringWords = myString.Split(' ');

        for (int i = 0; i < myStringWords.Length; i++)
        {

            for (int j = 0; j < myStringWords.Length; j++)
            {
                if(j == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write($"{myStringWords[j]} ");

            }

            Console.WriteLine();
        }

    }
    catch (Exception ex )
    {
        Console.WriteLine($"OOpsie! Något fel inträffade: {ex.Message}");
    }

}

//13. Rödmarkerade bokstäver
//Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. På första raden är de 5 första tecknen röda.
//På nästa rad är “bcdef” röda, sedan “cedfg” osv.. alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad,
//tills sista raden har “vwxyz” rödfärgad. Alltså:

//abcdefghijklmnopqrstuvwxyz
//abcdefghijklmnopqrstuvwxyz
//abcdefghijklmnopqrstuvwxyz
//... etc

static void Labb13()
{
    try
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        for (int i = 0; i < alphabet.Length - 4; i++)
        {
            string partOfAlphabet = alphabet.Substring(i, 5);

            for (int j = 0; j < alphabet.Length; j++)
            {
                if (j == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(partOfAlphabet);
                    j += 4;

                }
                else if (j < 26)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{alphabet[j]}");
                }
                
            }
            Console.WriteLine();
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"OOpsie! Något fel inträffade: {ex.Message}");
    }
}

//14. Rödmarkerade bokstäver 2
// Användaren matar in valfri sträng. Programmet skriver ut hela strängen bokstav för bokstav.
// Alla bokstäverna är röda fram tills du stöter på ett tecken som är samma som första tecknet i strängen.
// Därefter skriver den ut resten av bokstäverna med vit/grå färg. Några exempel vid olika inmatningar/körningar:
//ajdfhvajhdfd
//hhfgijff
//fjpdpog
static void Labb14()
{

    try 
    {
        string input = "asdfghjklasdfghjklasdfghjklasdfghjkl";
        char firstChar = input[0];

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == firstChar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.Write(input[i]);

            if (i > 0 && input[i] == firstChar) //Körs bara en gång och när den skall sluta skriva rött
            {
                Console.ForegroundColor = ConsoleColor.White;
                i++; //i++ för att inte skriva ut samma bokstav två gånger (röd och vit) när vi börjar skriva ut den vita. Funkar då denna bara körs 1 gång
                Console.Write(input[i]);
                firstChar = ' '; // För att programmet skall sluta leta efter fler firstChar att skriva ut i rött ändras värdet en gång

            }
        }

    }
    catch (Exception ex)
    {
        Console.Write($"Oops! Något gick fel: {ex.Message}");
    }
}

//15. Rödmarkerade bokstäver 3
//Användaren matar in valfri sträng. Programmet skriver sedan ut en hela strängen flera gånger.
//På första raden börjar den skriva med röd färg på första bokstaven och fram tills den hittar samma bokstav igen.
//På andra raden börjar den skriva med röd färg på andra bokstaven och fram tills den hittar samma bokstav igen.
//På tredje raden börjar den skriva med röd text på tredje bokstaven och fram tills den hittar samma igen...
//etc. Om man t.ex matar in “ajdfhvajhdfd” blir det då:
//ajdfhvajhdfd
//ajdfhvajhdfd
//... etc

static void Labb15()
{

    try
    {

        string input = "ajdfhvajhdfd";

        for (int i = 0; i < input.Length; i++)
        {
            char firstChar = input[i];

            for (int j = 0; j < input.Length; j++)
            {
                if (j == i && input[j] == firstChar)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(input[j]);

                if (input[j] == firstChar && j > i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.WriteLine();
            Console.ResetColor();

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Oops, något gick jävligt fel: {ex.Message}");
    }
}



/*try
{

    string alphabet = "abcdefghijklmnopqrstuvwxyz";

    for (int i = 0; i < alphabet.Length - 1; i++)
    {
        string partOfAlphabet = alphabet.Substring(i, 5);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(partOfAlphabet);

        if (i < alphabet.Length)
        {

            for (int j = 5; j < alphabet.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(alphabet[j + i]);


                if (j == alphabet.Length - 1)
                {
                    //int loopTracker = 0;

                    Console.WriteLine();
                    Console.Write(alphabet[i]);

                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Oj då, något fel inträffade: {ex.Message}");
}*/