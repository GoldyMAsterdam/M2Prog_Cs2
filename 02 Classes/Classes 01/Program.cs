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
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "Volkswagen"
            };
            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "Volvo"
            };
            Rijleraar rijeLeraar = new Rijleraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            LesUur lesUur = new LesUur()
            {   
                auto = auto1, 
                rijleraar = rijeLeraar,
                tijd = 1130
            };
            Student student = new Student()
            {
                leeftijd = 18,
                leraar = rijeLeraar,
                lesPakket = LesPakket.Gemiddeld,
                naam = "Piet",
                rijTest = RijTest.Geslaagd,
                theorieTest = TheorieTest.Geslaagd
            }; // Added missing semicolon here
        }
    }

    public class Auto
    {
        public bool automaat { get; set; }
        public string kenteken { get; set; }
        public int kilometerStand { get; set; }
        public string merk { get; set; }
    }

    public class Rijleraar
    {
        public int leeftijd { get; set; }
        public string naam { get; set; }
        public bool zzp { get; set; }
    }

    public class LesUur
    {
        public Auto auto { get; set; }
        public Rijleraar rijleraar { get; set; }
        public int tijd { get; set; }
    }

    public class Student
    {
        public int leeftijd { get; set; }
        public Rijleraar leraar { get; set; }
        public LesPakket lesPakket { get; set; }
        public string naam { get; set; }
        public RijTest rijTest { get; set; }
        public TheorieTest theorieTest { get; set; }
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
