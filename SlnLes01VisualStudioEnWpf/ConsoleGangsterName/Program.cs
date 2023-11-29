using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGangsterName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"**********************
|Gangsta Name Builder|
**********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Give the first name of any Disney character: ");
            String disneycharacterName = Console.ReadLine();
            
            Console.Write("Give any workbench tool: ");
            String workbenchTool = Console.ReadLine();
            
            Console.Write("What is your last name: ");
            String lastName = Console.ReadLine();
            Console.WriteLine();



            Console.Write("Your Gangsta name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{disneycharacterName} 'the {workbenchTool}' {lastName}");
            
            Console.ReadLine();
        }
    }
}
