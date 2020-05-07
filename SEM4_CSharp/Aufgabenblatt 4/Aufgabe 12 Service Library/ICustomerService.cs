using Aufgabe_12_Service_Library.model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Aufgabe_12_Service_Library
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        bool AddCustomer(Customer customer);
        [OperationContract]
        bool RemoveCustomer(Customer customer);
        [OperationContract]
        List<Customer> GetAllCustomers();
        [OperationContract]
        List<Customer> GetCustomers(string search);
    }
}
