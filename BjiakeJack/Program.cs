using System;

namespace BjiakeJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Блэйк Джек";

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.BufferWidth = 120;
            Console.WindowWidth = Console.BufferWidth;
            Console.WindowHeight = 40;
            Console.BufferHeight = Console.WindowHeight;

            DealCards DealCard = new();

            DealCard.Deal();
            Console.ReadLine();
        }
    }
}
