// teamnaam, stad

//team kan meerdere coaches hebben
//team kan meerdere spelers hebben


    public class Team
    {
        public string TeamNaam { get; set; }
        public string Stad { get; set; }

        public List<Speler> Spelers { get; set; } = new List<Speler>();

        public Coach Coach { get; set; }

        public Team(string teamnaam, string stad, Coach coach)
        {
            TeamNaam = teamnaam;
            Stad = stad;
            Coach = coach;
        }
        public void VoegSpelerToe(Speler speler)
        {
            Spelers.Add(speler);
        }

    }
