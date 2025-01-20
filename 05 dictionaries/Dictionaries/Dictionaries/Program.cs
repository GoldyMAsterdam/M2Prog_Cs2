using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace Dictionaries
{
    class Room
    {
        internal int x, y;
        internal string[] level;
        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }
        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }
    }

    internal class Program
    {
        private static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Room start = new Room(0, 0, [
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            ]);

            rooms.Add(start.GetRoomLocationKey(), start);

            static void ShowRoom(int x, int y)
            {
                Room room = rooms[$"{x},{y}"];

                Console.WriteLine($"You are in room: {x},{y}");
                foreach (string r in room.level)
                {
                    Console.WriteLine(r);
                }
            }
            RunPersonnelDictionaryExample();
        }

        static void RunPersonnelDictionaryExample()
        {
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
            personeelOpNummer.Add(382942, "jam");
            personeelOpNummer.Add(382943, "jim");

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