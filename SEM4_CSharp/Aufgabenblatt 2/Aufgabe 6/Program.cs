﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Employee));
            var employee = new Employee
            {
                FirstName = "Petra",
                LastName = "Maier",
                Gender = Gender.Diverse
            };


            using (var fileStream = File.Open("employee.xml", FileMode.Create))
            {
                serializer.Serialize(fileStream, employee);
            }

            Employee deserialized = null;

            using (var fileStream = File.Open("employee.xml", FileMode.Open))
            {
                deserialized = serializer.Deserialize(fileStream) as Employee;
            }

            if (deserialized != null)
            {
                Console.WriteLine($"Vorname: {deserialized.FirstName}, Nachname: {deserialized.LastName}, Geschlecht: {deserialized.Gender}");
            }

            Console.ReadKey();

        }
    }
}
