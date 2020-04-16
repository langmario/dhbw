using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aufgabe_7
{
    class Program
    {
        static IEnumerable<(string FirstName, string LastName, string Company, decimal SalesVolume)> GetSalesRepsFromBadenWuerttemberg(IEnumerable<SalesRepresentative> reps)
        {
            return from rep in reps
                   where rep.Area == "Baden-Württemberg"
                   orderby rep.Company ascending
                   select (rep.FirstName, rep.LastName, rep.Company, rep.SalesVolume);
        }


        static IEnumerable<IGrouping<string, SalesRepresentative>> GetSalesRepsGroupedByCompany(IEnumerable<SalesRepresentative> reps)
        {
            return from rep in reps
                   where rep.SalesVolume > 10_000
                   orderby rep.SalesVolume descending
                   group rep by rep.Company into newGroup
                   select newGroup;
        }


        static IEnumerable<SalesRepresentative> GetTopTenLosers(IEnumerable<SalesRepresentative> reps)
        {
            return reps.OrderBy((rep) => rep.SalesVolume).Take(10).Reverse();
        }



        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(SalesRepresentative[]));
            SalesRepresentative[] salesReps;

            using (var fileStream = File.OpenRead("vertreter.xml"))
            {
                salesReps = serializer.Deserialize(fileStream) as SalesRepresentative[];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Liste aller Vertreter aus Baden-Württemberg, sortiert nach Umsatz:");
            Console.ResetColor();
            GetSalesRepsFromBadenWuerttemberg(salesReps).ToList().ForEach(rep =>
            {
                Console.WriteLine($"\tName: {rep.FirstName} {rep.LastName}, Firma: {rep.Company}, Umsatz: {rep.SalesVolume}");
            });


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nListe aller Vertreter, gruppiert nach Unternehmen, die mehr als 10.000,- Umsatz machen, sortiert nach Unternehmen:");
            Console.ResetColor();
            GetSalesRepsGroupedByCompany(salesReps).ToList().ForEach(group =>
            {
                Console.WriteLine($"{group.Key}:");
                group.ToList().ForEach(rep =>
                {
                    Console.WriteLine($"\tName: {rep.FirstName} {rep.LastName}, Gebiet: {rep.Area}, Umsatz: {rep.SalesVolume}");
                });
            });


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nListe der 10 Vertreter, die am wenigsten Umsatz machen, sortiert nach Umsatz:");
            Console.ResetColor();
            GetTopTenLosers(salesReps).ToList().ForEach(rep =>
            {
                Console.WriteLine($"\tName: {rep.FirstName} {rep.LastName}, Gebiet: {rep.Area}, Umsatz: {rep.SalesVolume}");
            });


            Console.ReadKey();
        }
    }
}
