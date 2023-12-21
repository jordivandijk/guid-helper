using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guid
{
    internal static class ConsoleHelper
    {
        /// <summary>
        ///     Writes a console line in a specific color
        /// </summary>
        /// <param name="error"></param>
        internal static void WriteConsoleWithColor(string message, ConsoleColor consoleColor)
        {
            ConsoleColor currentCollor = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ForegroundColor = currentCollor;
        }

        /// <summary>
        ///     Writes basic info about this program
        /// </summary>
        internal static void WriteInfo()
        {
            Console.WriteLine("With guid you can generate random guids or valdiate a Guid.");
            Console.WriteLine("   Try new (ammount): This function will generate new guids and add them to your clipboard. The guids are separted using a new line so you can easly paste them in tables.");
            Console.WriteLine("   Try validate (guid)*: This function will validate if a given string is a valid guid. You can pass multiple by separting them with a whitespace.");
            WriteConsoleWithColor("    :) Jordi van Dijk", ConsoleColor.Cyan);
        }

    }
}
