using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print de nederlandse vlag
            Console.WriteLine("Nederlandse vlag:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█████████████");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("█████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("█████████████");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rusische vlag:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("█████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("█████████████");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█████████████");


            // Wacht op key press
            Console.ReadKey();
        }
    }
}
