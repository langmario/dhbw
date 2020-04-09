using Aufgabe_3;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var lkwFactory = new ObjectFactory<LKW>();
            var pkwFactory = new ObjectFactory<PKW>();
            var fahrzeugFactory = new ObjectFactory<Fahrzeug>();


            var lkw = lkwFactory.CreateInstance();
            var pkw = pkwFactory.CreateInstance();
            var fahrzeug = fahrzeugFactory.CreateInstance();
        }
    }
}
