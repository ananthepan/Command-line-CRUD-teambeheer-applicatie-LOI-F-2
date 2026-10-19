using System.Collections.Generic;

public class Team
{
    private static int volgendeId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public string Stad { get; set; }
    public List<Speler> Spelers { get; set; } = new List<Speler>();
    public List<Coach> Coaches { get; set; } = new List<Coach>();
    
    public Team(string name, string stad)
    {
        Id = volgendeId;
        volgendeId++;
        Name = name;
        Stad = stad;
    }

    public void VoegSpelerToe(Speler s)
    {
        if (!Spelers.Contains(s))
        {
            Spelers.Add(s);
        }
    }

    public void VerwijderSpeler(Speler s)
    {
        Spelers.Remove(s);
    }
}