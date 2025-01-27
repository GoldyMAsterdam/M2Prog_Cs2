using System;
using System.IO;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
        }
        string[] lines = File.ReadAllLines("Quiz.txt");
    }
}
