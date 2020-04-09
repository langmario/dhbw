using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "Tabulatoren\tsind auch Leerzeichen."
            };

            foreach (var message in messages)
            {
                
                Console.WriteLine($"{message}");
                Console.WriteLine($"> {message.CountWords()}");
            }

            Console.Read();
        }
    }
}
