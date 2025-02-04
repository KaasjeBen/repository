using System;

namespace Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print de Italiaanse vlag
            

            for (int i = 0; i < 12; i++) // Loop for 12 lines
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("██████████"); // Green part

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("██████████"); // White part

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("██████████\n"); // Red part
            }

            // Reset color
            Console.ResetColor();

            // Wacht op key press
            Console.ReadKey();
        }
    }
}