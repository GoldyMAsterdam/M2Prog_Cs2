using System;

namespace Classes_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            Auto auto1 = new Auto
            {
                Automaat = true,
                Kenteken = "AA824H",
                KilometerStand = 20567,
                Merk = "Volkswagen"
            };
            Auto auto2 = new Auto()
            {
                Automaat = false,
                Kenteken = "KU786G",
                KilometerStand = 65739,
                Merk = "Volvo"
            };
            Rijleraar rijeLeraar = new Rijleraar()
            {
                Leeftijd = 30,
                Naam = "John",
                Zzp = false
            };
            LesUur lesUur = new LesUur()
            {
                Auto = auto1,
                Rijleraar = rijeLeraar,
                Tijd = 1130
            };
            Student student = new Student()
            {
                Leeftijd = 18,
                Leraar = rijeLeraar,
                LesPakket = LesPakket.Gemiddeld,
                Naam = "Piet",
                RijTest = RijTest.Geslaagd,
                TheorieTest = TheorieTest.Geslaagd
            };
        }
    }

    public class Auto
    {
        public bool Automaat { get; set; }
        public string Kenteken { get; set; } = string.Empty;
        public int KilometerStand { get; set; }
        public string Merk { get; set; } = string.Empty;
    }

    public class Rijleraar
    {
        public int Leeftijd { get; set; }
        public string Naam { get; set; } = string.Empty;
        public bool Zzp { get; set; }
    }

    public class LesUur
    {
        public Auto Auto { get; set; } = new Auto();
        public Rijleraar Rijleraar { get; set; } = new Rijleraar();
        public int Tijd { get; set; }
    }

    public class Student
    {
        public int Leeftijd { get; set; }
        public Rijleraar Leraar { get; set; } = new Rijleraar();
        public LesPakket LesPakket { get; set; }
        public string Naam { get; set; } = string.Empty;
        public RijTest RijTest { get; set; }
        public TheorieTest TheorieTest { get; set; }
    }

    public enum LesPakket
    {
        Basis,
        Gemiddeld,
        Intensief
    }

    public enum RijTest
    {
        NietGeslaagd,
        Geslaagd
    }

    public enum TheorieTest
    {
        NietGeslaagd,
        Geslaagd
    }
}
