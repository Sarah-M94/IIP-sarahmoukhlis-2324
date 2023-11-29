using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMahjong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"********************
|Welkom Bij Mahjong|
********************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("druk op een");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" om de steen te tonen...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ◉◉◉ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ◉◉◉ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ◉◉◉ ");
            Console.ResetColor();
            Console.WriteLine("druk op een toets om af te sluiten...");

            Console.ReadKey();



        }
    }
}
