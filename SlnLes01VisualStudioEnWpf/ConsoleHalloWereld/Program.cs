using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("hallo wereld");
            Console.Write("hoe heet je?");
            String Naam = Console.ReadLine();
            Console.Write("aangename kenninsmaking, ");
            Console.WriteLine(Naam);
            Console.WriteLine("druk een toets om verder te gaan");
            Console.ReadLine();
        }
    }
}
