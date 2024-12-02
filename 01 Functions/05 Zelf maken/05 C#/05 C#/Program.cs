using System;

namespace Readlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
            AskRandomQuestion();
        }

        static void AskRandomQuestion()
        {
            string question = GetRandomVraag();
            Console.WriteLine(question);

            string antwoord = Console.ReadLine();
            Console.WriteLine($"You answered: {antwoord}");
        }

        static string GetRandomVraag()
        {
            string[] vragen = {
                "What is the 1997 N64 video game featuring James Bond, named after the 1995 film?",
                "What arcade game was called Puckman in Japan?",
                "How long do you think you'd survive in a zombie apocalypse?",
                "What secret conspiracy would you like to actually start letting other people know?",
                "If you can still remember, what are your funniest childhood memories?",
                "What would you do if you won a million dollars?",
                "What is the worst game you played but that you liked anyway?",
                "Which species would be the rudest if all animals could talk?",
                "Hoe oud ben jij?"
            };

            Random random = new Random();
            int index = random.Next(vragen.Length);
            return vragen[index];
        }
    }
}
