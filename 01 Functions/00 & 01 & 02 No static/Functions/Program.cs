namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run(); /* Hier functie gemaakt. Type is static.
                              De function die we gaan gebruik is Run*/
        }

        //function
        private void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
    }
}
