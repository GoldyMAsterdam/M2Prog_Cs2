namespace Readlines
{
    internal class Program
    {
        string[] vragen = new string[] {
            "What is 1997 N64 video game, features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan"
        };
        static void Main(string[] args)
        {
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
            Vraag7();
        }

        internal static void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
        }
        internal static void Vraag2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
        }
        internal static void Vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
        }
        internal static void Vraag4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
        }
        internal static void Vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
        }
        internal static void Vraag6()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();
        }
        internal static string Vraag7()
        {
            Console.WriteLine("Hoe oud ben jij");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
            string vraag1 = GetVraag(1);
            string vraag2 = GetVraag(2);
            string vraag3 = GetVraag(3);
        }
    }
}
