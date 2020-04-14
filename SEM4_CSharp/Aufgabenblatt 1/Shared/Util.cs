using System;
using System.Threading.Tasks;

namespace Shared
{
    public class Util
    {

        public static void WaitForInput()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

    }
}
