namespace Aufgabe_11.Models
{
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string StreetNumber { get; set; } = string.Empty;
        public int PostCode { get; set; }
        public string City { get; set; } = string.Empty;
    }
}
