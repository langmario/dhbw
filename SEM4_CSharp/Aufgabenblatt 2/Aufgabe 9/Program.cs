using System;

namespace Aufgabe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.NameChanged += Console.WriteLine;

            person.FirstName = "Donna";
            person.LastName = "Summer";

            Console.ReadKey();
        }
    }
}
