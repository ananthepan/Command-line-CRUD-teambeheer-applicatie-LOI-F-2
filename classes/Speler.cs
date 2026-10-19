using System.Collections.Generic;
using System.Data.Common;

//speler kan meerdere teams hebben

public class Speler
{
    public int Id { get; private set;}
    public string Name { get; set;}
    public int Rugnummer { get; set;}
    public Positie Positie { get; set;}
    public List<Team> Teams { get; set; } = new List<Team>();

    private static int volgendeId = 1;

    //constructor
    public Speler(string name, int rugnummer, Positie positie)
{
    Id = volgendeId;
    volgendeId++;
    Name = name;
    Rugnummer = rugnummer;
    Positie = positie;
}
}

public enum Positie
    {
        keeper,
        verdediger,
        middenvelder,
        aanvaller
    }
    