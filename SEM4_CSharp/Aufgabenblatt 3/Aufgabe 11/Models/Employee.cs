namespace Aufgabe_11.Models
{
    public class Employee
    {
        public string Firstname { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public Gender Gender { get; set; }
    }
}
