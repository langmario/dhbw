namespace Aufgabe_3
{
    public class Fahrzeug
    {
        public string Kennzeichen { protected get; set; }

        public virtual string Drive()
        {
            return Kennzeichen;
        }
    }
}
