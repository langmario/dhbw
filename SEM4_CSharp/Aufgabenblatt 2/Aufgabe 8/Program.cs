using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                FirstName = "Herbert",
                LastName = "Müller",
                Gender = Gender.Male
            };


            var formatter = new BinaryFormatter();

            Employee deserialized;

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, employee);

                stream.Position = 0;

                deserialized = formatter.Deserialize(stream) as Employee;
            }

            if (deserialized != null)
            {
                Console.WriteLine("Original:");
                Console.WriteLine($"Vorname: {employee.FirstName}, Nachname: {employee.LastName}, Geschlecht: {employee.Gender}");
                Console.WriteLine("Copy:");
                Console.WriteLine($"Vorname: {deserialized.FirstName}, Nachname: {deserialized.LastName}, Geschlecht: {deserialized.Gender}");
            }


            Console.ReadKey();
        }
    }
}
