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

        public MainPage()
        {
            this.InitializeComponent();

            // Voorbeelddata: drie teams, elk met een coach en spelers
            Team vitesse = new Team("Vitesse", "Arnhem", new Coach("Rudiger Rehm"));
            vitesse.VoegSpelerToe(new Speler("Jeredy Hilterman", 19, Speler.SpelerRol.Aanvaller, new DateTime(1998, 07, 20)));
            vitesse.VoegSpelerToe(new Speler("Piet Jansen", 1, Speler.SpelerRol.Keeper, new DateTime(1995, 03, 14)));
            Teams.Add(vitesse);

            Team psg = new Team("PSG", "Parijs", new Coach("Luis Enrique"));
            psg.VoegSpelerToe(new Speler("Vitor Machado Ferreira", 17, Speler.SpelerRol.Middenvelder, new DateTime(1999, 11, 2)));
            Teams.Add(psg);

            Team manUnited = new Team("Manchester United", "Manchester", new Coach("Michael Carrick"));
            manUnited.VoegSpelerToe(new Speler("Diogo Dalot", 27, Speler.SpelerRol.Verdediger, new DateTime(2000, 5, 30)));
            Teams.Add(manUnited);

            RefreshGrid();
        }


    }
