using _04_Lists;
using System;

namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Welkom bij ForHerhaling!");


            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 15.75 };
            string[] artikelen = { "snoepje", "luxe broodje", "lunch menu", "diner" };
            Formulier[] formulieren = new Formulier[2];

           formulieren[0] = new Formulier
            {
                Sterren = 4,
                Feedback = "Goedkoop en lekker"
            };

            formulieren[1] = new Formulier
            {
                Sterren = 5,
                Feedback = "Prijzig maar lekker"
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[1]);
            }

            Console.WriteLine("\nReviews:");
            foreach (var formulier in formulieren)
            {
                Console.WriteLine($"Sterren: {formulier.Sterren}, Feedback: {formulier.Feedback}");
            }
        }
    }
}
