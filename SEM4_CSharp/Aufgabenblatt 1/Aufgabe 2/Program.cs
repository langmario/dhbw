using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu Aufgabe 2");

            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();

                switch (input.Trim())
                {
                    case "zählen":
                        zaehlen();
                        break;

                    case "hilfe":
                        printHelp();
                        break;

                    case "exit":
                    case "beenden":
                        exit().Wait();
                        return;

                    case "clear":
                        Console.Clear();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültiges Kommando");
                        Console.ResetColor();
                        break;
                }

            } while (true);
        }


        private static async Task exit()
        {
            Console.WriteLine("Tschüss");
            await Task.Delay(400);
        }


        private static void printHelp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("zählen  ->  zählt von einer eingegebenen unteren Grenze bis zu einer oberen Grenze");
            Console.WriteLine("hilfe   ->  gibt eine Übersicht aller Befehle aus");
            Console.WriteLine("beenden ->  beendet das Programm");
            Console.WriteLine("clear   ->  löscht die Eingabehistorie");
            Console.ResetColor();
        }


        private static void zaehlen()
        {
            Console.Write("Minimaler Wert: ");
            if (int.TryParse(Console.ReadLine(), out int lower))
            {
                Console.Write("Maximaler Wert: ");
                if (int.TryParse(Console.ReadLine(), out int upper))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = lower; i <= upper; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ResetColor();

                    return;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ungültige Eingabe!");
            Console.ResetColor();
        }
    }
}
