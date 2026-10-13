
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        bool loopBreak = true;

        while (loopBreak == true)
        {
            Console.WriteLine("Welkom bij de Voetbal Applicatie");
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("1. Teams bekijken");
            Console.WriteLine("2. Spelers bekijken");
            Console.WriteLine("3. Teams aanpassen");
            Console.WriteLine("4. Spelers aanpassen");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

            switch (choice)
            {
                case 1:
                    TeamsBekijken();
                    break;

                case 2:
                    SpelersBekijken();
                    break;

                case 3:
                    TeamsAanpassen();
                    break;

                case 4:
                    SpelersAanpassen();
                    break;

                case 5:
                    Console.WriteLine("Applicatie afsluiten");
                    loopBreak = false;
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                    break;
            }
            break;
        }
    }

    // Methods
    static void TeamsBekijken()
    {
        Console.WriteLine("Teams ");

        

        //Case 0: 
        ConsoleWriteline("Terug naar het menu");
    }

    static void SpelersBekijken()
    {
        Console.WriteLine("Spelers bekijken");

        //Case 0: 
        ConsoleWriteline("Terug naar het menu");
    }

    static void TeamsAanpassen()
    {
        Console.WriteLine("Teams aanpassen");

        //Case 0: 
        ConsoleWriteline("Terug naar het menu");
    }

    static void SpelersAanpassen()
    {
        Console.WriteLine("Spelers aanpassen");

        //Case 0: 
        ConsoleWriteline("Terug naar het menu");
    }
}





//voetbal teams worden getoond
//spelers worden getoond na klikken van een team
//team toevoegen
//speler toevoegen
//teams aanpassen(crud)
//spelers aanpassen(crud)
//opslaan, systeem onthoudt(zonder behulp van database)
//exit loop
//applicatie afsluiten


