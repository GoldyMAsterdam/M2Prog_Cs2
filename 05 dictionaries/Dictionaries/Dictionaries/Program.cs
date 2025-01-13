using System.Collections.Generic;
using System.IO.Pipes;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
            {
                personeelOpNummer.Add(382942, "jam");
                personeelOpNummer.Add(382943, "jim");
            }
            string jam = personeelOpNummer[382942];
            string jim = personeelOpNummer[382943];
            Console.WriteLine(personeelOpNummer[382942]);
            Console.WriteLine(personeelOpNummer[382943]);

            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                string value = item.Value;
                Console.WriteLine($"Key: {item.Key}, Value: {value}");
            }
        }
    }
}
