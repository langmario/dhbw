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
            Console.WriteLine("Willkommen zu Aufgabe2");
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
                    case "beenden":
                        return;
                    default:
                        Console.WriteLine("Ungültiges Kommando");
                        break;
                }

            } while (true);
        }

        private static void printHelp()
        {
            Console.WriteLine("zählen\t->\tzählt von einer eingegebenen unteren Grenze bis zu einer oberen Grenze");
            Console.WriteLine("hilfe\t->\tgibt eine Übersicht aller Befehle aus");
            Console.WriteLine("beenden\t->\tbeendet das Programm");
        }


        private static void zaehlen()
        {
            Console.Write("Minimaler Wert: ");
            if (int.TryParse(Console.ReadLine(), out int lower))
            {
                Console.Write("Maximaler Wert: ");
                if (int.TryParse(Console.ReadLine(), out int upper))
                {
                    for (int i = lower; i <= upper; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }
    }
}
