using System;
using System.Collections.Generic;
class Program
{
    //list refs
    static List<Team> teams = new List<Team>();
    static List<Speler> players = new List<Speler>();
    static List<Coach> coaches = new List<Coach>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welkom bij de Voetbal Applicatie");
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("1. Teams bekijken");
            Console.WriteLine("2. Spelers bekijken");
            Console.WriteLine("3. Teams beheren");
            Console.WriteLine("4. Spelers beheren");
            Console.WriteLine("5. Afsluiten");

            int choice = ReadMenuChoice("Uw keuze: ");
            Console.Clear();

            switch (choice)
            {
                case 1:
                    ViewTeams();
                    break;
                case 2:
                    ViewPlayers();
                    break;
                case 3:
                    ManageTeams();
                    break;
                case 4:
                    ManagePlayers();
                    break;
                case 5:
                    Console.WriteLine("Applicatie afgesloten");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                    Pause();
                    break;
            }
        }
    }

    // Input helpers 

    static int ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("Ongeldige invoer, typ een getal.");
        }
    }

    static string ReadText(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine("Invoer mag niet leeg zijn.");
        }
    }

    static int ReadMenuChoice(string prompt)
    {
        Console.Write(prompt);
        char key = Console.ReadKey(true).KeyChar;

        if (char.IsDigit(key))
        {
            return key - '0';

        }
        return -1;
    }

    //Display helpers

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Druk op een toets om verder te gaan...");
        Console.ReadKey(true);
    }

    static void ShowTeams()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("Er zijn nog geen teams.");
            return;
        }

        foreach (Team team in teams)
        {
            Console.WriteLine(team.Id + ". " + team.Name + " (" + team.Stad + ")");
        }
    }

    static void ShowPlayers()
    {
        if (players.Count == 0)
        {
            Console.WriteLine("Er zijn nog geen spelers.");
            return;
        }

        foreach (Speler player in players)
        {
            Console.WriteLine(player.Id + ". " + player.Name + " - nr " + player.Rugnummer + " - " + player.Positie);

            foreach (Team t in player.Teams)
            {
                Console.WriteLine("    team: " + t.Name);
            }
        }
    }

    // view
    static void ViewTeams()
    {
        Console.WriteLine("Teams");
        Console.WriteLine();
        ShowTeams();

        //terug naar het menu
        Pause();
    }

    static void ViewPlayers()
    {
        Console.WriteLine("Spelers");
        Console.WriteLine();
        ShowPlayers();

        //terug naar het menu
        Pause();
    }

    // Manage teams

    static void ManageTeams()
    {
        bool back = false;

        while (!back)
        {
            Console.Clear();
            Console.WriteLine("Teams beheren");
            Console.WriteLine("Wat wilt u doen?");
            //funtion, class smth for displaying number (number , nuber actis assigned automatically evertime a new object has been created) for team so the number can be clicked and the selected team is displayed the folllowing options for.
            //selcted key = according team number. for selected key, team is selected and the following menu is displayed.

            Console.WriteLine("1. Teams bekijken");
            Console.WriteLine("2. Team toevoegen");
            Console.WriteLine("3. Team aanpassen");
            Console.WriteLine("4. Team verwijderen");
            Console.WriteLine("5. Terug naar het hoofdmenu");

            int choice = ReadMenuChoice("Uw keuze: ");
            Console.Clear();

            switch (choice)
            {
                case 1:
                    ViewTeams();
                    break;
                case 2:
                    AddTeam();
                    break;
                case 3:
                    EditTeam();
                    break;
                case 4:
                    DeleteTeam();
                    break;
                case 5:
                    back = true;
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                    Pause();
                    break;
            }
        }
    }

    static void AddTeam()
    {
        string name = ReadText("Naam van het team: ");
        string city = ReadText("Naam van de stad: ");
        teams.Add(new Team(name, city));
        Console.WriteLine("Team toegevoegd.");
        Pause();
    }

    static void EditTeam()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("Er zijn geen teams om te bewerken");
            Pause();
            return;
        }

        ShowTeams();
        int id = ReadNumber("Id van het team: ");
        Team found = teams.Find(t => t.Id == id);


        if (found == null)
        {
            Console.WriteLine("Dat team bestaat niet.");
            Pause();
            return;
        }
        string name = ReadText("Voer teamnaam in: ");
        string city = ReadText("Voer stadsnaam in: ");

        found.Name = name;
        found.Stad = city;

        Console.WriteLine("Team aangepast.");
        Pause();
    }

    static void DeleteTeam()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("Er zijn geen teams om te verwijderen");
            Pause();
            return;
        }

        ShowTeams();
        int id = ReadNumber("Id van het team: ");
        Team found = teams.Find(t => t.Id == id);

        if (found == null)
        {
            Console.WriteLine("Dat team bestaat niet.");
        }
        else
        {
            foreach (Speler s in found.Spelers)
            {
                s.Teams.Remove(found);
            }
            teams.Remove(found);
            Console.WriteLine("Team verwijderd.");
        }

        Pause();
    }

    // Manage players

    static void ManagePlayers()
    {
        bool back = false;

        while (!back)
        {
            Console.Clear();
            Console.WriteLine("Spelers beheren");
            Console.WriteLine("Wat wilt u doen?");
            // Console.WriteLine("Welke Speler wilt u aanpassen?");
            // Console.WriteLine("Kies 1 -> speler toevoegen");
            // Console.WriteLine("Kies 2 -> speler aanpassen");
            // Console.WriteLine("Kies 3 -> speler verwijderen");

            //add
            //edit
            //delete

            Console.WriteLine("1. Spelers bekijken");
            Console.WriteLine("2. Speler toevoegen");
            Console.WriteLine("3. Speler aanpassen");
            Console.WriteLine("4. Speler verwijderen");
            Console.WriteLine("5. Speler aan een team koppelen");
            Console.WriteLine("6. Terug naar het hoofdmenu");

            int choice = ReadMenuChoice("Uw keuze: ");
            Console.Clear();

            switch (choice)
            {
                case 1:
                    ViewPlayers();
                    break;
                case 2:
                    AddPlayer();
                    break;
                case 3:
                    EditPlayer();
                    break;
                case 4:
                    DeletePlayer();
                    break;
                case 5:
                    LinkPlayerToTeam();
                    break;
                case 6:
                    //terug naar het menu
                    back = true;
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze, probeer het opnieuw.");
                    Pause();
                    break;
            }
        }
    }

    static void AddPlayer()
    {
        string name = ReadText("Naam van de speler: ");
        int jerseyNumber = ReadNumber("Rugnummer van de speler: ");

        Console.WriteLine("1. keeper, 2. verdediger, 3. middenvelder, 4. aanvaller");
        int positionNumber = ReadNumber("Welke positie heeft de speler (1-4): ");

        while (positionNumber < 1 || positionNumber > 4)
        {
            Console.WriteLine("Deze invoer wordt niet herkend, kies een getal van 1 tot en met 4.");
            positionNumber = ReadNumber("Welke positie heeft de speler (1-4): ");
        }

        Positie position = (Positie)(positionNumber - 1);

        players.Add(new Speler(name, jerseyNumber, position));
        Console.WriteLine("Speler toegevoegd.");
        Pause();
    }

    static void EditPlayer()
    {
        if (players.Count == 0)
        {
            Console.WriteLine("Er zijn geen spelers om te bewerken.");
            Pause();
            return;
        }

        ShowPlayers();
        int id = ReadNumber("Id van de speler: ");
        Speler found = players.Find(p => p.Id == id);

        if (found == null)
        {
            Console.WriteLine("Die speler bestaat niet.");
            Pause();
            return;
        }

        string name = ReadText("Voer de naam van de speler in: ");
        int jerseyNumber = ReadNumber("Voer het rugnummer in: ");

        Console.WriteLine("1. keeper, 2. verdediger, 3. middenvelder, 4. aanvaller");
        int positionNumber = ReadNumber("Welke positie heeft de speler (1-4): ");

        while (positionNumber < 1 || positionNumber > 4)
        {
            Console.WriteLine("Deze invoer wordt niet herkend, kies een getal van 1 tot en met 4.");
            positionNumber = ReadNumber("Welke positie heeft de speler (1-4): ");
        }

        found.Name = name;
        found.Rugnummer = jerseyNumber;
        found.Positie = (Positie)(positionNumber - 1);

        Console.WriteLine("Speler aangepast.");
        Pause();
    }

    static void DeletePlayer()
    {

        if (players.Count == 0)
        {
            Console.WriteLine("Er zijn geen spelers om te verwijderen");
            Pause();
            return;
        }

        ShowPlayers();
        int id = ReadNumber("Id van de speler: ");
        Speler found = players.Find(p => p.Id == id);

        if (found == null)
        {
            Console.WriteLine("Die speler bestaat niet.");
        }
        else
        {
            foreach (Team t in found.Teams)
            {
                t.Spelers.Remove(found);
            }
            players.Remove(found);
            Console.WriteLine("Speler verwijderd.");
        }

        Pause();
    }

    static void LinkPlayerToTeam()
    {
        // check for empty lists
        if (teams.Count == 0)
        {
            Console.WriteLine("Er zijn nog geen teams.");
            Pause();
            return;
        }

        if (players.Count == 0)
        {
            Console.WriteLine("Er zijn nog geen spelers");
            Pause();
            return;
        }

        // team selecteren
        ShowTeams();
        int teamId = ReadNumber("Id van het team: ");
        Team foundTeam = teams.Find(t => t.Id == teamId);

        if (foundTeam == null)
        {
            Console.WriteLine("Dat team bestaat niet.");
            Pause();
            return;
        }

        //speler selecteren
        ShowPlayers();
        int playerId = ReadNumber("Id van de speler: ");
        Speler foundPlayer = players.Find(p => p.Id == playerId);

        if (foundPlayer == null)
        {
            Console.WriteLine("Die speler bestaat niet.");
            Pause();
            return;
        }

        // al gekoppeld?
        if (foundTeam.Spelers.Contains(foundPlayer))
        {
            Console.WriteLine("Deze speler zit al in dit team.");
            Pause();
            return;
        }

        //koppelen in beide richtingen
        foundTeam.VoegSpelerToe(foundPlayer);
        foundPlayer.Teams.Add(foundTeam);

        Console.WriteLine("Speler gekoppeld aan team.");
        Pause();
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