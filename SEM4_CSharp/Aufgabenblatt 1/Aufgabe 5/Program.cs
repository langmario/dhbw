using Shared;
using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new[]
            {
                "Es ist heute ein sehr schöner Tag in Horb am Neckar.",
                "Diese Zeichenkette ist nicht lang, denke ich.",
                "Tabulatoren\tsind auch Leerzeichen.",
                "Test t",
                "",
                "     "
            };

            foreach (var message in messages)
            {
                Console.WriteLine($"> \"{message}\"");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Word Count: {message.CountWords()} ({message.CountWordsRegex()})");
                Console.ResetColor();
            }


            Util.WaitForInput();
        }
    }
}
