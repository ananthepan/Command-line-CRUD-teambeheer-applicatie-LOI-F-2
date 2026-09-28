//spelernaam
//rugnummer
//positie enum(keeper, verdediger, middenvelder, aanvaller)
//eventueel geboortedatum, met exampple dag/maand/jaar

//speler kan meerdere teams hebben

public class Speler
    {
        public string SpelerNaam { get; set; }
        public int RugNummer { get; set; }
        public Positie Positie { get; set; }


        public Speler(string spelernaam, int rugnummer, Positie positie)
        {
            SpelerNaam = spelernaam;
            RugNummer = rugnummer;
            Positie = positie;
        }
    }

    public enum Positie
    {
        Keeper,
        Verdediger,
        Middenvelder,
        Aanvaller
    }