using System;

namespace Fourth_Class
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
        // Console.WriteLine("Hello World");
        Console.Clear();

        Console.WindowWidth = 150;
        Console.WindowHeight = 50;
        Console.ForgroundColor = ConsoleColor.BarkBlue;
        Console.BackroundColor =  ConsoleColor.Black;
        Coonsole.WriteLine($"WIdth:"  + Console.WindowWidth);
        Coonsole.WriteLine($"Height:"  + Console.WindowHeight);

        for (int y = 0; y < Console.WindowHeight; y++) {
            for (int x = 0; x < Console.WindowWidth; x++) {
                Console.SetCursorPosition(x, y);
                Console.Write('');
            }
        }

        int x, y;

        do 
        {
            x = rnd.Next(Console.WindowWidth);
            y = rnd.Next(Console.WindowWidth);
                Console.Write('');

        } while (true);
        
        // ---------------------------------------------------------------


        int x, y;

        COnsoleColor[] colors = new COnsoleColor[]  {
            ConsoleColor.Red,ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Magenta,ConsoleColor.Cyan,
            ConsoleColor.Yellow,ConsoleColor.Gray,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,Console025
        }



        Console.ReadKey();
        }
    }
} 
