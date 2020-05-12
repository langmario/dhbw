namespace Aufgabe_13.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public Gender Gender { get; set; }
    }
}
