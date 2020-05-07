using System.Runtime.Serialization;

namespace Aufgabe_12_Service_Library.model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        public bool IsPremiumCustomer { get; set; }

        public override bool Equals(object obj) => obj is Customer c && FirstName == c.FirstName && LastName == c.LastName;
    }
}
