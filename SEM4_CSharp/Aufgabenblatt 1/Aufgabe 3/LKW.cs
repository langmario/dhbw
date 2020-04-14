namespace Aufgabe_3
{
    public class LKW : Fahrzeug
    {
        public new string Drive()
        {
            return $"LKW {Kennzeichen}";
        }
    }
}
