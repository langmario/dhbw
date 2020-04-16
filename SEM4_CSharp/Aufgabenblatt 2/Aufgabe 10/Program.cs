using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Aufgabe_10
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new OleDbConnectionStringBuilder
            {
                DataSource = "beispiel.mdb",
                Provider = "Microsoft.Jet.OLEDB.4.0"
            };

            using (var conn = new OleDbConnection(builder.ConnectionString))
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT Vorname, Name FROM Vertreter";
                    var result = await command.ExecuteReaderAsync();
                    
                    if (result.HasRows)
                    {
                        while(result.Read())
                        {
                            Console.WriteLine($"{result.GetString(1)}, {result.GetString(0)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found...");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
