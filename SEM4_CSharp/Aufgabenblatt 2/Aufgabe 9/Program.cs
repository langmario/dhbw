using System;

namespace Aufgabe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.NameChanged += name => Console.WriteLine(name);

            person.FirstName = "Donna";
            person.LastName = "Summer";

            Console.ReadKey();
        }
    }
}
