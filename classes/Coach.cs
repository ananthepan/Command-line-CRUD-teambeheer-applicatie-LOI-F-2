using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// coach kan meerdere teams hebben

public class Coach
    {
        public int Id { get; private set;}
        public string CoachNaam { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();

        //constructor
        public Coach(string coachnaam)
        {
            Id = volgendeId;
            volgendeId++;
            CoachNaam = coachnaam;
        }
           private static int volgendeId = 1;
    }